using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models.DTO.InComing
{
    public class image
    {
        public long id { get; set; }

        public string file_name { get; set; }

        public int width { get; set; }

        public int height { get; set; }
    }
}
