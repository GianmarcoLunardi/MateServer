using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MakeSense.Models
{
    // La Riga della tabella è rappresentata tramite i campi dell oggetto di tipo
    // Coordinate
    public class Coordinate
    {

        // Chiave primariria che identifica il punto
        [Key]
        public Guid Id { get; set; }
        //Punto
        [Required]
        public float Point { get; set; }
    }
}
