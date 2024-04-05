using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models.DTO.InComing
{
    public class annotation
    {
        public long id { get; set; }

        public bool iscrowd { get; set; }
        public long image_id { get; set; }
        public long category_id { get; set; }
        public List<float> segmentation { get; set; }
        public float area { get; set; }
        public List<float> bbox { get; set; }
    }
}


/*
 *  "annotations": [
        {
            "id": 0,
            "iscrowd": 0,
            "image_id": 1,
            "category_id": 1,
          "segmentation": [
            [
              262.8424396155016,
              67.23820754716982,
              175.51696791738834,
              174.77122641509436,
              296.0405528230487,
              314.058962264151,
              511.8282886721053,
              266.4268867924528,
              424.50281697399214,
              129.30424528301887
            ]
          ],

            "bbox": [
                175.51696791738834,
                67.23820754716982,
                336.311320754717,
                246.82075471698116
            ],
            "area": 48356.58548415808
 */