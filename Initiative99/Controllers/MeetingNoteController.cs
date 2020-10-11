using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Initiative99.Models;
using Initiative99.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Initiative99.Controllers
{
	[Route("api/MeetingNote")]
	[ApiController]
	public class MeetingNoteController : ControllerBase
	{
		private IMeetingNoteRepository MeetingNoteRepository { get; }

		public MeetingNoteController(IMeetingNoteRepository meetingNoteRepository)
		{
			MeetingNoteRepository = meetingNoteRepository;
		}

		// GET: api/<MeetingNoteController>
		[HttpGet("{id}")]
		[Route("GetMeetingNote/{id}")]
		public async Task<IActionResult> GetMeetingNoteById(int id)
		{
			var Initiative = await MeetingNoteRepository.GetMeetingNoteById(id);
			return Ok(Initiative);
		}

		// GET: api/<MeetingNoteController>
		[HttpGet("{id}")]
		[Route("GetMeetingNotebyMeetingId/{id}")]
		public async Task<IActionResult> GetMeetingNoteByMeetingId(int id)
		{
			var Initiative = await MeetingNoteRepository.GetMeetingNoteByMeetingId(id);
			return Ok(Initiative);
		}

		// POST api/<MeetingNoteController>
		[HttpPost]
		[Route("CreateMeetingNote")]
		public async Task<IActionResult> CreateMeetingNote(MeetingNote data)
		{
			MeetingNote record = new MeetingNote
			{
				CreatedBy = data.CreatedBy,
				CreatedDate = DateTime.Now,
				Updatedby = data.Updatedby,
				UpdatedDate = DateTime.Now,
				Note = data.Note,
				MeetingId = data.MeetingId

			};
			
			var response = await MeetingNoteRepository.CreateMeetingNote(record);
			return Ok(response);
		}

		// PATCH api/<MeetingNoteController>/5
		[HttpPatch]
		[Route("UpdateMeetingNote")]
		public async Task<IActionResult> UpdateMeetingNote(MeetingNote meetingNote)
		{
			var response = await MeetingNoteRepository.UpdateMeetingNote(meetingNote);
			return Ok(response);
		}

		// DELETE api/<MeetingNOteController>/5
		[HttpDelete("{id}")]
		[Route("DeleteMeetiingNote/{id}")]
		public async Task<IActionResult> DeleteInitiative(int id)
		{
			var response = await MeetingNoteRepository.DeleteMeetingNote(id);
			return Ok(response);
		}
	}
}
