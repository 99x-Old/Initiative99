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
	[Route("api/User")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private IUserRepository UserRepository { get; }

		public UserController(IUserRepository userRepository)
		{
				UserRepository = userRepository;
		}
		// GET: api/<UserController>
		[HttpGet("{id}")]
		[Route("GetUserById/{id}")]
		public async Task<IActionResult> GetUserById(long id)
		{
			var user = await UserRepository.GetUserById(id);
			return Ok(user);
		}

		//// GET api/<UserController>/5
		//[HttpGet]
		//[Route("GetUser")]
		//public string Get(int id)
		//{
		//	return "value";
		//}

		// POST api/<UserController>
		[HttpPost]
		[Route("CreateUser")]
		public async Task<IActionResult> CreateUser(User data)
		{
			var response = await UserRepository.CreateUser(data);
			return Ok(response);
		}

		// PATCH api/<UserController>/5
		[HttpPatch]
		[Route("UpdateUser")]
		public async Task<IActionResult> UpdateUser(User user)
		{
			var response = await UserRepository.UpdateUser(user);
			return Ok(response);
		}
		
		// DELETE api/<UserController>/5
		[HttpDelete("{id}")]
		[Route("DeleteUser/{id}")]
		public async Task<IActionResult> DeleteUser(long id)
		{
			var response = await UserRepository.DeleteUser(id);
			return Ok(response);
		}
	}
}
