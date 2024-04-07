using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    [Table("Image")]
    public class Image
    {
        [Key]    
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string State { get; set; }


        public DateTime DonationOn { get; set; }
        //public User MyProperty { get; set; }

        // è il solito campo di file Name
        //[Column("File Name")]
        //public string File_Name { get; set; }

        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string Model { get; set; }
        //Lenti della macchina forografica
        public string Lens { get; set; }
        // Dati relativi al immagine
        //grandezza
        public int Size { get; set; }
        // Formato
        public string Format { get; set; }
        //Larghezza file

        //campo chiave esterna
        //public List<Annotation> Annotations { get; set; }

        //public User UpdatedBy { get; set; }
       


    }
}
