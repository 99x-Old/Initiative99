using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Models
{
	public class Comment
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CommentId { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public long InitiativeActionId { get; set; }
		public InitiativeAction InitiativeAction { get; set; }
		public long UserId { get; set; }
		public User User { get; set; }

	}
}
