using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Segmentation
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        float Point { get; set; }
    }

}
