using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHandson.Models
{
    public class Command
    {
        [Key]
        public int id { get; set; }
        
        [Required]
        
        public string Comment { get; set; }
        

    }
}
