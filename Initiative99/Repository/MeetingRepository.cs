using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class MeetingRepository : IMeetingRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public MeetingRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}
		public async Task<bool> CancelMeeting(int id)
		{
			var record = await GetMeetingById(id);
			record.Status = 2;
			InitiativeContext.Meetings.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}
		public async Task<Meeting> GetMeetingById(int Id)
		{
			return await InitiativeContext.Meetings.FirstOrDefaultAsync(m => m.MeetingId == Id);
		}

		public async Task<bool> DeleteMeeting(int id)
		{
			var record = await GetMeetingById(id);
			record.Status = 0;
			InitiativeContext.Meetings.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<List<Meeting>> GetAllMeetings()
		{
			return await InitiativeContext.Meetings.Where(i => i.Status == 1).ToListAsync();
		}

		public async Task<bool> ScheduleMeeting(Meeting meeting)
		{
			await InitiativeContext.Meetings.AddAsync(meeting);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> UpdateMeeting(Meeting meeting)
		{
			var record = await GetMeetingById(meeting.MeetingId);
			record.Date = meeting.Date;
			record.Time = meeting.Time;
			record.Subject = meeting.Subject;
			record.ScheduledBy = meeting.ScheduledBy;
			record.InitiativeId = meeting.InitiativeId;
			record.Status = meeting.Status;
			InitiativeContext.Meetings.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}	
	}
}
