using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class Context : DbContext
    {
        // https://dbdiagram.io/d/AI-Odontoiatria-Vers-2-6615403003593b6b6192c7c5

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

         //public DbSet<Project> Projects { get; set; }
        //public DbSet<Segmentation> Segmentations { get; set; }
        
      
       //public DbSet<Coordinate> Coordinates { get; set; }
       // public DbSet<CoordinateB> CoordinateB { get; set; }

       //public DbSet<Category> Categories { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Image> Images { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Registry> Registries { get; set; }

        //public DbSet<Annotation> Annotations { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Root> roots { get; set; }



    }
}
