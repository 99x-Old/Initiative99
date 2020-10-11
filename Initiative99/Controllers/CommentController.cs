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
	[Route("api/comment")]
	[ApiController]
	public class CommentController : ControllerBase
	{
		private ICommentRepository CommentRepository { get; }

		public CommentController(ICommentRepository commentRepository)
		{
			CommentRepository = commentRepository;
		}
		// GET: api/<CommentController>
		[HttpGet("id")]
		[Route("api/commentbyid/{id}")]
		public async Task<IActionResult> GetCommentByActioin(long id)
		{
			var comment = await CommentRepository.GetCommentByActionId(id);
			return Ok(comment);
		}

		// POST api/<CommentController>
		[HttpPost]
		[Route("add")]
		public async Task<IActionResult> CreateComment(Comment data)
		{
			Comment record = new Comment
			{
				Description = data.Description,
				Date = DateTime.Now,
				//InitiativeActionId = data.InitiativeAction,
				//UserId = data.User,
			};
			var response = await CommentRepository.CreateComment(record);
			return Ok(response);
		}

		// patch api/<CommentController>/5
		[HttpPatch("{id}")]
		[Route("Update")]
		public async Task<IActionResult> UpdateComment(Comment comment)
		{
			var response = await CommentRepository.UpdateComment(comment);
			return Ok(response);
		}

		// DELETE api/<CommentController>/5
		[HttpDelete("{id}")]
		[Route("Delete/{id}")]
		public async Task<IActionResult> DeleteComment(int id)
		{
			var response = await CommentRepository.DeleteComment(id);
			return Ok(response);
		}
	}
}
