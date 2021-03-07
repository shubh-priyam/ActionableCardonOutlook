using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHandson.DTOs
{
    public class CommandCreateDto
    {
        [Required]
        
        public string Comment { get; set; }

    }
}
