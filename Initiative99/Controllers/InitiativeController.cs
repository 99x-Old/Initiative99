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
	[Route("api/initiative")]
	[ApiController]
	public class InitiativeController : ControllerBase
	{
		private IInitiativeRepository InitiativeRepository { get; }

		public InitiativeController(IInitiativeRepository initiativeRepository)
		{
			InitiativeRepository = initiativeRepository;
		}
		// GET: api/<InitiativeController>
		[HttpGet]
		[Route("GetInitiative")]
		public async Task<IActionResult>  GetInitiativeList()
		{
			var Initiatives = await InitiativeRepository.GetAllInitiatives();
			return Ok(Initiatives);
		}

		// GET api/<InitiativeController>/5
		[HttpGet("{id}")]
		[Route("GetInitiative/{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var Initiative = await InitiativeRepository.GetInitiativeById(id);
			return Ok(Initiative);
		}

		// POST api/<InitiativeController>
		[HttpPost]
		[Route("PostInitiative")]
		public async Task<IActionResult> CreateInitiative(Initiative data)
		{
			var response = await InitiativeRepository.CreateInitiative(data);
			return Ok(response);
		}

		// PUT api/<InitiativeController>/5
		[HttpPatch]
		[Route("UpdateInitiative")]
		public async Task<IActionResult> UpdateInitiative(Initiative initiative)
		{
			var response = await InitiativeRepository.UpdateInitiative(initiative);
			return Ok(response);
		}

		// DELETE api/<InitiativeController>/5
		[HttpDelete("{id}")]
		[Route("DeleteInitiative/{id}")]
		public async Task<IActionResult> DeleteInitiative(long id)
		{
			var response = await InitiativeRepository.DeleteInitiative(id);
			return Ok(response);
		}
	}
}
