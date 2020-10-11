using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Models
{
	public class UserInitiativeAction
	{
		[Key]
		public long UserId { get; set; }
		public User User { get; set; }
		[Key]
		public long InitiativeActionId { get; set; }
		public InitiativeAction InitiativeAction { get; set; }

	}
}
