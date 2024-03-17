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
        public long Id { get; set; }

        [Column("File Name")]
        public string File_Name { get; set; }

        //Larghezza file
        public int Width { get; set; }

        //Altezza
        public int Height { get; set; }

        /*
        // Campi opzionali per futuri svolgimento del progetto
        [Column("Id File")]
        public long Id_File { get; set; }


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
