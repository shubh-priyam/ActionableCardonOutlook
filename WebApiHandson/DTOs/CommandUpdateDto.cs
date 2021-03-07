using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApiHandson.DTOs
{
    public class CommandUpdateDto
    {
        [Required]
        public string Comment { get; set; }

    }
}
