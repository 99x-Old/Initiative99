using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Models
{
	public class Meeting
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MeetingId { get; set; }
		public DateTime Date { get; set; } 
		public DateTime Time { get; set; }
		public string Subject { get; set; } 
		public long ScheduledBy { get; set; }
		public int Status { get; set; }
		public long InitiativeId { get; set; }
		public Initiative initiative { get; set; }



	}
}
