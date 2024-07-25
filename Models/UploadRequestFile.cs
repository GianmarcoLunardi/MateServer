using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Chiedere che differenza c'è fra i due oggetti
/// </summary>



namespace MakeSense.Models
{
    public class UploadRequestFile
    {
        [BindRequired]

        public IFormFile? File { get; set; }
        public _State? State { get; set; }
        
        public DateTime? DonationOn { get; set; }
        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }


    }

    public class UploadRequestFileTest
    {
        public IFormFile? File;
        public _State? State;
        /*
        public DateTime? DonationOn { get; set; }
        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        */

    }

}
