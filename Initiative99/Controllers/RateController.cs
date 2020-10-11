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
	[Route("api/Rate")]
	[ApiController]
	public class RateController : ControllerBase
	{
		private IRateRepository RateRepository { get; }

		public RateController(IRateRepository rateRepository)
		{
			RateRepository = rateRepository;
		}
		// GET: api/<RateController>
		[HttpGet]
		[Route("getRatebyUser/{id}")]
		public async Task<IActionResult> GetRateByUserId(long id)
		{
			var Initiative = await RateRepository.GetRateByUserId(id);
			return Ok(Initiative);
		}

		// GET api/<RateController>/5
		[HttpGet("{id}")]
		[Route("{id}")]
		public async Task<IActionResult> GetRateById(int id)
		{
			var Initiative = await RateRepository.GetRateById(id);
			return Ok(Initiative);
		}

		// POST api/<RateController>
		[HttpPost]
		[Route("add")]
		public async Task<IActionResult> Createrate(Rate data)
		{
			var response = await RateRepository.CreateRate(data);
			return Ok(response);
		}

		// PATCH api/<RateController>/5
		[HttpPatch]
		[Route("Update")]
		public async Task<IActionResult> UpdateRate(Rate rate)
		{
			var response = await RateRepository.UpdateRate(rate);
			return Ok(response);
		}

		// DELETE api/<RateController>/5
		[HttpDelete("{id}")]
		[Route("Remove/{id}")]
		public async Task<IActionResult> DeleteRate(int id)
		{
			var response = await RateRepository.DeletRate(id);
			return Ok(response);
		}
	}
}
