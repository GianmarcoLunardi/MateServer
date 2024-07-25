using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Models
{
    //https://dbdiagram.io/d/AI-Odontoiatria-Vers-2-6615403003593b6b6192c7c5

    public enum _State
    {
        uploaded,
        dowloaded,
        pending,
        rejected,
        eligible,
        assigned,
        completed,
        Approved
    }



    [Table("Image")]
    public class Image
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        // public IFormFile? File { get; set; }
        // è stato scaricato
        // 1 scaricato
        // specificato
        // int di enum
        public _State State { get; set; }

 


        // Da aggiungere come relazione
        //public DateTimr ApprovedBy { get; set; }



        // è il solito campo di file Name
       // [Column("File Name")]
        public string File_Name { get; set; }

        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        // Dati relativi al immagine
        //grandezza
       
        public long? Size { get; set; }
        // Formato
        public string? Format { get; set; }
        //Larghezza file

        //campo chiave esterna
        //public List<Annotation> Annotations { get; set; }

        //public User UpdatedBy { get; set; }

        public Label Label { get; set; }

        public DateTime? DonationOn { get; set; }


        //public string? DonationBy { get; set; }

        public string? DonationBy { get; set; }





        public DateTime ApprovedOn { get; set; }

        // Prima era una stringa


        [ForeignKey("User")]
        //public Guid IdUser { get; set; } // Required foreign key property
        public User ApprovedBy { get; set; } = null!; // Required reference navigation to principal

        public List<Registry> Registries { get; set; }

        public int? PixelX { get; set; }
        public int? PixelY { get; set; }



    }
}
