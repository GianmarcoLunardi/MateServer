using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Annotation
    {
        public long Id{ get; set; }

        public bool iscrowd { get; set; }
        public long image_id { get; set; }
        public long category_id { get; set; }
        public  List<Coordinate> Segmentations { get; set; }
        public  float Area { get; set; }
        public List<CoordinateB> Bbox { get; set; }
    }
}
