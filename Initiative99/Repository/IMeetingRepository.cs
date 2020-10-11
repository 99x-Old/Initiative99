using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface IMeetingRepository
	{
		Task<List<Meeting>> GetAllMeetings();
		Task<Meeting> GetMeetingById(int Id);
		Task<bool> ScheduleMeeting(Meeting meeting);
		Task<bool> CancelMeeting(int id);
		Task<bool> DeleteMeeting(int id);
		Task<bool> UpdateMeeting(Meeting meeting);
	}
}
