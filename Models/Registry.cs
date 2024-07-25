using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Registry
    {
        public Guid Id { get; set; }

        [ForeignKey("Image")]
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
        

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public DateTime RegistratedOn { get; set; }
        public string Operation { get; set; }
        public string Description { get; set; }
    }
}
