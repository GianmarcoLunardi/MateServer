using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeSense.Services.Interface
{
    public interface IServiceUtente
    {



        //Task<string> UploadFile(IFormFile file);
        //Task<IFormFile> DownLoadFile(string file);
        //Task<string> UploadFileMulti(ImageIn Immagine);
        // Quà metto un oggetto grezzo, un model Image che contiene ancora id senza utilizzare 
        // il dto

        //Task<Image?> AddAsync(Image Immagine);
        void Add( User entity);
        List<User> ListUser();
        User Find(Guid id);
        Task<User[]> ListAsyn();
        IList<GuidName> menu();
    }
}
