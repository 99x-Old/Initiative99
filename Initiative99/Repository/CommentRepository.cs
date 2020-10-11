using Initiative99.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public class CommentRepository:ICommentRepository
	{
		private InitiativeContext InitiativeContext { get; }

		public CommentRepository(InitiativeContext initiativeContext)
		{
			InitiativeContext = initiativeContext;
		}

		public async Task<List<Comment>> GetCommentByActionId(long id)
		{
			return await InitiativeContext.Comment.Where(i => i.CommentId == id).ToListAsync();
		}

		public async Task<bool> CreateComment(Comment comment)
		{
			await InitiativeContext.Comment.AddAsync(comment);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteComment(long id)
		{
			Comment record = await InitiativeContext.Comment.FirstOrDefaultAsync(j => j.CommentId == id);
			InitiativeContext.Comment.Remove(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}

		public async Task<bool> UpdateComment(Comment comment)
		{
			Comment record =  await InitiativeContext.Comment.FirstOrDefaultAsync(i => i.CommentId == comment.CommentId);
			record.Description = comment.Description;
			InitiativeContext.Comment.Update(record);
			return await InitiativeContext.SaveChangesAsync() > 0;
		}
	}
}
