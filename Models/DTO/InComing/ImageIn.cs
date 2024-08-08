using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// C:\Users\Gianmarco\Documents\C\MakeSense\Models\DTO\InComing\ImageIn.cs
namespace MakeSense.Models.DTO.InComing
{


  
    public class ImageIn
    {
 
        public IFormFile? File { get; set; }
        // è stato scaricato
        // 1 scaricato
        // specificato
        // int di enum
       // public _State? State { get; set; }

        // Da aggiungere come relazione
        //public DateTimr ApprovedBy { get; set; }


        //Category può contenere solo i campi
        //Labeled
        //difficult_cases
        //unclassifiable_cases



        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        // Dati relativi al immagine


        public DateTime? DonationOn { get; set; }
        public string? DonationBy { get; set; }

        public DateTime? ApprovedOn { get; set; }
        public Guid? UserId { get; set; }
        //public string? ApprovedBy { get; set; }


    }

   
}
