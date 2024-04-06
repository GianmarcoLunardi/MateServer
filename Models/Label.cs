using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;

namespace MakeSense.Models
{
    public class Label
    {
        public Guid Id { get; set; }

        public string LabelImage { get; set; } 
        //public Image ImageId  { get; set; }
        public User LabeledBy { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Highth { get; set; }
    }
}
