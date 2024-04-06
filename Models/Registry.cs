using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Registry
    {
        public Guid Id { get; set; }
        public Image ImageId { get; set; }
        public DateTime RegistratedOn { get; set; }
        public string Operation { get; set; }
        public string Description { get; set; }
    }
}
