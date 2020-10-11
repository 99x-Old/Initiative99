using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Models
{
	public class MeetingNote
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MeetingNoteId { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Updatedby { get; set; }
		public DateTime UpdatedDate { get; set; }
		[System.Runtime.Serialization.IgnoreDataMember]
		public string Note { get; set; }
		public int MeetingId { get; set; }
		public Meeting meeting { get; set; }
	}
}
