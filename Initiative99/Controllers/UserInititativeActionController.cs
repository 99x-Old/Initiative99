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
	[Route("api/userinitiativeaction")]
	[ApiController]
	public class UserInititativeActionController : ControllerBase
	{
		private IUserInitiativeActionRepository UserInitiativeActionRepository { get; }

		public UserInititativeActionController(IUserInitiativeActionRepository userInitiativeActionRepository)
		{
			UserInitiativeActionRepository = userInitiativeActionRepository;
		}

		// GET api/<UserInititativeAction>/5
		[HttpGet("{id}")]
		[Route("useraction/{id}")]
		public async Task<IActionResult> GetUserById(long id)
		{
			var response = await UserInitiativeActionRepository.GetUsersByAction(id);
			return Ok(response);
		}
		// GET api/<UserInititativeAction>/actionId
		[HttpGet("{id}")]
		[Route("actionsByUser/{id}")]
		public async Task<IActionResult> GetActionsByUserId(long id)
		{
			var response = await UserInitiativeActionRepository.GetActionsByUserId(id);
			return Ok(response);
		}

		// POST api/<UserInititativeAction>
		[HttpPost]
		[Route("add")]
		public async Task<IActionResult> CreateUserAction(UserInitiativeAction data)
		{
			var response = await UserInitiativeActionRepository.CreateUserAction(data);
			return Ok(response);
		}

		// PUT api/<UserInititativeAction>/5
		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		// DELETE api/<UserInititativeAction>/5
		[HttpDelete("{id}")]
		[Route("Delete/{id}")]
		public async Task<IActionResult> DeleteUserAction(long ActionId, long userid)
		{
			var response = await UserInitiativeActionRepository.DeleteUserAction(ActionId,userid);
			return Ok(response);
		}
	}
}
