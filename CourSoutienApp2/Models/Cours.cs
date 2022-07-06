using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourSoutienApp2.Models
{
    public class Cours
    {
        [Key]
        public int CoursId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Intitule { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Prof { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Lieu { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heured { get; set; }
        public DateTime Heuref { get; set; }
    }
}
