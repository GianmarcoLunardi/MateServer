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


        public DateTime DonationBy { get; set; }
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
        //public int? Width { get; set; }
        //Altezza
        //public int? Height { get; set; }

        //Campi Del JSON

        public List<Annotation> Annotations { get; set; }


        /*


        // chi fornisce l immagine

        [Column("Donator Id")]
        public long Donator_ID { get; set; }
        // La persona che ha itechittato l immagine
       
        [Column("Labeled Id")]
        public int Labelled_ID_User { get; set; }

        // Lente con cui è stato fotografato
        public string Lens { get; set; }

        // Marca Macchina Fotografica
        public string Brend { get; set; }

        // Modello Macchina Forografica
        public int Brand { get; set; }
        [Column("Assignment date time")]
        public DateTime Assignment_date_time { get; set; }

        */

    }
}
