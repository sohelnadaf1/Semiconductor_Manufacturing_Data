using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CGA_Data_project_1.Models
{
    public class CPU
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ModelNumber { get; set; }
        [Required]
        public int Memory { get; set; }
        [Required]
        public int TotalCores { get; set; }
        public int Transistor { get; set; }
        public double Version { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

    }
}
