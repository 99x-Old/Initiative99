using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Models
{
	public class Rate
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RateId { get; set; }
		public int Value { get; set; }
		public int RateBy { get; set; }
		public long UserId { get; set; }
		public User User { get; set; }

	}
}
