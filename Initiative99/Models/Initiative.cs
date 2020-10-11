using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Initiative99.Models
{
    public class Initiative
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Initiativid { get; set; }
        public string Name { get; set; }
        public int InitiativeYear { get; set; }
        public DateTime CreatedDate { get; set; } 
        public string Description { get; set; }
        public bool Status { get; set; }
        //public long InitiativeActionId { get; set; }
       
    }
}
