﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    public class CoordinateB
    {

            // Chiave primariria che identifica il punto
            [Key]
            public Guid Id { get; set; }
            //Punto
            public float Point { get; set; }

    }
}
