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
	[Route("api/initiativeAction")]
	[ApiController]
	public class InitiativeActionController : ControllerBase
	{
		private IInitiativeActionRepository InitiativeActionRepository { get; }

		public InitiativeActionController(IInitiativeActionRepository initiativeActionRepository)
		{
			InitiativeActionRepository = initiativeActionRepository;
		}
		// GET: api/<InitiativeActionController>
		[HttpGet]
		[Route("GetInitiativeActions")]
		public async Task<IActionResult> GetInitiativeActionList()
		{
			var response = await InitiativeActionRepository.GetAllInitiativeAction();
			return Ok(response);
		}

		// GET api/<InitiativeActionController>/5
		[HttpGet("{id}")]
		[Route("GetInitiativeAction/{id}")]
		public async Task<IActionResult> GetInitiativeActionById(long id)
		{
			var InitiativeAction = await InitiativeActionRepository.GetInitiativeActionById(id);
			return Ok(InitiativeAction);
		}
		// GET api/<InitiativeActionController>/5
		[HttpGet("{id}")]
		[Route("GetInitiativeActionByInitiative/{id}")]
		public async Task<IActionResult> GetInitiativeActionByInitiativeId(long id)
		{
			var InitiativeAction = await InitiativeActionRepository.GetInitiativeActionByInitiativeId(id);
			return Ok(InitiativeAction);
		}

		// POST api/<InitiativeActionController>
		[HttpPost]
		[Route("PostInitiativeAction")]
		public async Task<IActionResult> CreateInitiativeAction(InitiativeAction data)
		{
			var response = await InitiativeActionRepository.CreateInitiativeAction(data);
			return Ok(response);
		}

		// PATCH api/<InitiativeActionController>/5
		[HttpPut("{id}")]
		[Route("UpdateInitiativeAction")]
		public async Task<IActionResult> UpdateInitiativeAction(InitiativeAction initiativeAction)
		{
			var response = await InitiativeActionRepository.UpdateInitiativeAction(initiativeAction);
			return Ok(response);
		}

		// DELETE api/<InitiativeActionController>/5
		[HttpDelete("{id}")]
		[Route("DeleteInitiative/{id}")]
		public async Task<IActionResult> DeleteInitiative(long id)
		{
			var response = await InitiativeActionRepository.DeleteInitiativeAction(id);
			return Ok(response);
		}
	}
}
