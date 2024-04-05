using MakeSense.Models.DTO.InComing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models.DTO.input
{
    public class CocoJsonRequest
    {
        public Info info { get; set; }
         public List<image> images { get; set; }
         public List<annotation> annotations { get; set; }
          public List<categorie> categories { get; set; }

    }
}
