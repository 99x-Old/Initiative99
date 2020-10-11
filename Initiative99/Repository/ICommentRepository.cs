using Initiative99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Repository
{
	public interface ICommentRepository
	{
		Task<List<Comment>> GetCommentByActionId(long id);
		Task<bool> CreateComment(Comment comment);
		Task<bool> DeleteComment(long id);
		Task<bool> UpdateComment(Comment comment);
	}
}
