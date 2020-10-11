using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class MeetingNoteRepository : IMeetingNoteRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public MeetingNoteRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}

		public async  Task<MeetingNote> GetMeetingNoteById(int Id)
		{
			return await InitiativeContext.MeetingNote.FirstOrDefaultAsync(i => i.MeetingNoteId == Id);
		}

		public async Task<MeetingNote> GetMeetingNoteByMeetingId(int Id)
		{
			return await InitiativeContext.MeetingNote.FirstOrDefaultAsync(j => j.MeetingId == Id);
		}

		public async Task<bool> CreateMeetingNote(MeetingNote meetingNote)
		{
			
			await InitiativeContext.MeetingNote.AddAsync(meetingNote);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteMeetingNote(int id)
		{
			 MeetingNote record  = await InitiativeContext.MeetingNote.FirstOrDefaultAsync(j => j.MeetingNoteId == id);
			InitiativeContext.MeetingNote.Remove(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> UpdateMeetingNote(MeetingNote meetingNote)
		{
			var record = await GetMeetingNoteById(meetingNote.MeetingNoteId);
			record.Updatedby = meetingNote.Updatedby;
			record.UpdatedDate = DateTime.Now;
			record.MeetingId = meetingNote.MeetingId;
			record.Note = meetingNote.Note;
			InitiativeContext.MeetingNote.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}
	}
}
