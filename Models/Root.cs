using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Root
    {
        [Key]
        public long Id { get; set; }
        public string description { get; set; }
        public ICollection<Image> images { get; set; }
    }
}
