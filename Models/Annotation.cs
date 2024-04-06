using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Annotation
    {
        public Guid Id{ get; set; }

        public bool? iscrowd { get; set; }
        public Guid image_id { get; set; }
        public Guid? category_id { get; set; }
        public  List<Coordinate> Segmentations { get; set; }
        // doppio campo
        public string segmentation_text { get; set; }

        public float? Area { get; set; }
        public List<CoordinateB> Bbox { get; set; }
        //doppio campo
        public string? bbbox_string { get; set; }
    }
}
