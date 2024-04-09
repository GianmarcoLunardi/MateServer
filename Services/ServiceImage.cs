using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services.Interface;
using Microsoft.AspNetCore.Http;

namespace MakeSense.Services
{
    public class ServiceImage : IServiceImage
    {
        private readonly Context BaseDati;

        public ServiceImage(Context baseDati)
        {
            BaseDati = baseDati;
        }



        /// <summary>
        /// https://www.youtube.com/watch?v=6-FNejMrVuk
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>

        public async Task<string> UploadFile(IFormFile file)
        {
            //false l autenticazione


            // controlla il tipo di file
            // se l estenzione è quella giusta 

            List<string> ValidExtention = new List<string>  { ".jpg" , ".tif"};
            string extention = Path.GetExtension(file.FileName);
            if (!ValidExtention.Contains(extention)){
                Console.WriteLine("ERRORE NELL ESTENZIONE DEI FILE");

               // Console.WriteLine("------Ci siamooooooo-----JPGGGGGGGGGGG");

                return   "con estenzione non possibile"; }
            // controlla la dimenzione
            long lunghezza = file.Length;
            if (lunghezza > (10 * 1024 * 1024))
            {
                return " dimenzoione superiore a 10Mb";
            }
            
            // controlla 


            // cambia nome

            string NomeFile = "Foto" + Guid.NewGuid().ToString() + extention;

            // percorso file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Foto");
            using FileStream stram = new FileStream(Path.Combine (path , NomeFile), FileMode.Create);
            file.CopyTo(stram);
            Console.WriteLine("------Ci siamooooooo-----File Copiato " + path+NomeFile);
            return NomeFile;
            //throw new NotImplementedException();
        }
    }
}
