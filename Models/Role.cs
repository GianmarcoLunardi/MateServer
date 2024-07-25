using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public int TypeCode { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> User { get; set; }
    }
}
