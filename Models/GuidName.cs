using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class GuidName
    {
       public GuidName ( string idParm,string nomeParm ) 
        {
            this.id = idParm;
            this.name = nomeParm;
        }
       public string id { get; set; }
       public string name { get; set; }
    }
}
