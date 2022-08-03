using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CGA_Data_project_1.Models
{
    public class Brands
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }

        
    }
}
