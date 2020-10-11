using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface IMeetingNoteRepository
	{
		Task<MeetingNote> GetMeetingNoteById(int Id);
		Task<MeetingNote> GetMeetingNoteByMeetingId(int Id);
		Task<bool> CreateMeetingNote(MeetingNote meetingNote);
		Task<bool> DeleteMeetingNote(int id);
		Task<bool> UpdateMeetingNote(MeetingNote meetingNote);
	}
}
