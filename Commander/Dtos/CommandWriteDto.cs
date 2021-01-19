using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandWriteDto
    {
        [Required]
        [MaxLength(50)]
        public string HowTo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Line { get; set; }
        [Required]
        [MaxLength(50)]
        public string Platform { get; set; }
    }
}
