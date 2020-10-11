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
	[Route("api/Meeting")]
	[ApiController]
	public class MeetingController : ControllerBase
	{
		private IMeetingRepository MeetingRepository { get; }

		public MeetingController(IMeetingRepository meetingRepository)
		{
			MeetingRepository = meetingRepository;
		}

		// GET api/<MeetingController>/5
		[HttpGet("{id}")]
		[Route("GetMeeting/{id}")]
		public async Task<IActionResult> GetMeetingById(int id)
		{
			var Initiative = await MeetingRepository.GetMeetingById(id);
			return Ok(Initiative);
		}

		// POST api/<MeetingController>
		[HttpPost]
		[Route("CreateMeeting")]
		public async Task<IActionResult> CreateMeeting(Meeting data)
		{
			var response = await MeetingRepository.ScheduleMeeting(data);
			return Ok(response);
		}

		// PATCH api/<MeetingController>/5
		[HttpPatch]
		[Route("UpdateMeeting")]
		public async Task<IActionResult> UpdateMeeting(Meeting meeting)
		{
			var response = await MeetingRepository.UpdateMeeting(meeting);
			return Ok(response);
		}
		[HttpPatch("{id}")]
		[Route("CancelMeeting/{id}")]
		public async Task<IActionResult> CancelMeeting(int Id)
		{
			var response = await MeetingRepository.CancelMeeting(Id);
			return Ok(response);
		}

		//DELETE api/<MeetingController>/5
		[HttpDelete("{id}")]
		[Route("DeleteMeetiing/{id}")]
		public async Task<IActionResult> DeleteInitiative(int id)
		{
			var response = await MeetingRepository.DeleteMeeting(id);
			return Ok(response);
		}
	}
}
