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
        //[MinLength(5, ErrorMessage = "Field Name , required min 5 characters")]
        //[MaxLength(50, ErrorMessage = "Field Name --- max 50 characters")]
        //[Required( ErrorMessage ="Field Name Required ")]
        
        public IFormFile? File { get; set; }
        // è stato scaricato
        // 1 scaricato
        // specificato
        // int di enum
       // public _State? State { get; set; }

        // Da aggiungere come relazione
        //public DateTimr ApprovedBy { get; set; }



        // è il solito campo di file Name
        //[Column("File Name")]
        //public string File_Name { get; set; }


        //[DataType("string" , ErrorMessage = "Il campo deve essere stringa ")]
        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        // Dati relativi al immagine
        //grandezza
        //[MinLength(50 , ErrorMessage="Size minlegth 20 characters")]
        // il campo può essere calcolato dall file
        //public long? Size { get; set; }
        // Formato
        // Il vampo può essere calcolato dall upload del file
        //public string? Format { get; set; }
        //Larghezza file

        //campo chiave esterna
        //public List<Annotation> Annotations { get; set; }

        public DateTime? DonationOn { get; set; }
        public string? DonationBy { get; set; }

        public DateTime? ApprovedOn { get; set; }
        public string? ApprovedBy { get; set; }

       // public int? PixelX { get; set; }
      //  public int? PixelY { get; set; }

    }
}

