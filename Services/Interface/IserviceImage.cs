using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Models.DTO.InComing;
using Microsoft.AspNetCore.Http;

namespace MakeSense.Services.Interface
{
    public interface IServiceImage
    {
        Task<string> UploadFile(IFormFile file);
        Task<IFormFile> DownLoadFile(string file);
        Task<string> UploadFileMulti(ImageIn Immagine);
        // Quà metto un oggetto grezzo, un model Image che contiene ancora id senza utilizzare 
        // il dto
        Task<Image> GetFoto(Guid id);
        Task<Image?> AddAsync(Image Immagine);
        Task Add(Image Immagine);
        Task<IEnumerable<Image>> ListAsyn();
        Task ResetUpload();

        Task approva(Guid IDUSER, Guid IDFOto);

        // Return the file namer From guid Image
        ///Task<Image> GetFotoDetal(Guid id);
        Task<string> GetNameFoto(Guid id);

    }
}

/*
 
        public string Name { get; set; }
        // è stato scaricato
        // 1 scaricato
        // specificato
        // int di enum
        public _State? State { get; set; }


        public DateTime DonationOn { get; set; }
        //public User MyProperty { get; set; }

        // è il solito campo di file Name
        //[Column("File Name")]
        //public string File_Name { get; set; }

        public string? Category { get; set; }
        // Marca di macchina fotografica
        public string? Brand { get; set; }
        //Modello della macchina Fotografica
        public string? Model { get; set; }
        //Lenti della macchina forografica
        public string? Lens { get; set; }
        // Dati relativi al immagine
        //grandezza
        [MinLength(50)]
        public int? Size { get; set; }
        // Formato
        public string? Format { get; set; }
 
 */