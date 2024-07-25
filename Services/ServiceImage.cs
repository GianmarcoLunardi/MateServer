using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MakeSense.Models;
using MakeSense.Models.DTO.InComing;
using MakeSense.Models.DTO.input;
using MakeSense.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MakeSense.Services
{
    public class ServiceImage : IServiceImage
    {
        private readonly Context BaseDati;

        private string NomeFileImmagine="" ;

        public ServiceImage(Context baseDati)
        {
            BaseDati = baseDati;
        }

        //https://www.youtube.com/watch?v=5HuFPNuopNM
        // moltiform
        //https://www.youtube.com/watch?v=_WYr6pwDieA
        /// <summary>
        /// https://www.youtube.com/watch?v=6-FNejMrVuk
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        ///

        public async Task ResetUpload()
        {
            var lista = BaseDati.Images;

            foreach ( Image x in lista)
            {
                x.State = _State.dowloaded;
            }


            await BaseDati.SaveChangesAsync();



        }

        // cerca e ritorna un immagine nella tabella
        public async Task<Image> GetFoto(Guid guid)
        {

            return await BaseDati.Images.FindAsync(guid);
             
        }

        public async Task<IEnumerable<Image>> ListAsyn()
        {
            return BaseDati.Images;
        }


        public async Task<Image?> AddAsync(Image Immagine) {

            // string FileFoto = await  UploadFile(FileCaricato);
            /*
            Immagine.Name = FileFoto;
            Immagine.Format = Path.GetExtension(FileFoto);
            Immagine.Size = FileCaricato.Length;

            await BaseDati.Images.AddAsync(Immagine);

            */
            EntityEntry<Image> added = await BaseDati.Images.AddAsync(Immagine);
            int affected = await BaseDati.SaveChangesAsync();
            // 
            // 
           // BaseDati.SaveChanges();
           if (affected ==1 ) 
            { return Immagine; }
            else
            {
                return null;
            }
        
        }

        public async Task Add(Image Immagine)
        {

            // string FileFoto = await  UploadFile(FileCaricato);
            /*
            Immagine.Name = FileFoto;
            Immagine.Format = Path.GetExtension(FileFoto);
            Immagine.Size = FileCaricato.Length;

            await BaseDati.Images.AddAsync(Immagine);

            */

            Console.WriteLine(" entradeo dentro Add " + Immagine.Name);
            // await BaseDati.Images.AddAsync(Immagine);
            BaseDati.Images.Add(Immagine);
            // await BaseDati.SaveChangesAsync();
            BaseDati.SaveChanges();

        }

        //    ApprovedBy
        //    
        //    scarica(nome)---> file

        //public async Task<string> UploadFileMulti(UploadRequestFile Immagine)
        //public async Task<string> UploadFileMulti(Image Immagine)


        public async Task<string> GetNameFoto(Guid id) {
             Image x = await BaseDati.Images.FindAsync(id);
            // cambio lo stato della foto
            x.State = _State.uploaded;
            BaseDati.Images.Update(x);
            await BaseDati.SaveChangesAsync();
            return x.File_Name;
        }



        public async Task<string> UploadFileMulti(ImageIn Immagine)
        /// questo metodi 
        {

            //string extention = Path.GetExtension(Immagine.File.FileName);
            // cambia nome
            // oral_img-20240111-1206-2_Alber􀆟_Beatrice_DL-Nikon-3300-105mm
            // string NomeFile = "Foto" + Guid.NewGuid().ToString() + extention;
            // Nel nome file manca da inserire i dati del login 

            string NomeFile = "oral_img-";
            NomeFile = NomeFile + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            NomeFile = NomeFile + Immagine.Model+ "-" + Immagine.Brand + "-" + Immagine.Lens;
            NomeFile = NomeFile + Path.GetExtension(Immagine.File.FileName);


            // Salvataggio Del File
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Foto");
            using FileStream stram = new FileStream(Path.Combine(path, NomeFile), FileMode.Create);
            Immagine.File.CopyTo(stram);
            this.NomeFileImmagine = NomeFile;
            return NomeFile;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        /// https://www.youtube.com/watch?v=xZV42p9QCh8
        /// https://www.youtube.com/watch?v=xZV42p9QCh8geMggIBhAAGBYYHjIICAcQABgWGB4yCAgIEAAYFhgeMggICRAAGBYYHtIBCTE2MjUyajBqNKgCALACAQ&sourceid=chrome&ie=UTF-8#fpstate=ive&vld=cid:51afff94,vid:xZV42p9QCh8,st:0
        public async Task<IFormFile> DownLoadFile(string file) {
            string path = Path.Combine(Directory.GetCurrentDirectory(), file);


            return null;
        }
        public async Task<string> UploadFile(IFormFile file)
        {
            //false l autenticazione


            // validazione dei paramentri passsati
            // https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-8.0

            // controlla il tipo di file
            // se l estenzione è quella giusta 

            List<string> ValidExtention = new List<string>  { ".jpg" , ".tif"};
            string extention = Path.GetExtension(file.FileName);
if              (!ValidExtention.Contains(extention)){
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
// oral_img-20240111-1206-2_Alber􀆟_Beatrice_DL-Nikon-3300-105mm
// string NomeFile = "Foto" + Guid.NewGuid().ToString() + extention;

                    string NomeFile = "oral_img-";
                    NomeFile = NomeFile + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
                    NomeFile = NomeFile;

                    NomeFile = NomeFile + extention;
                        //NomeFile = 
                        // percorso file
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "Foto");
                    using FileStream stram = new FileStream(Path.Combine (path , NomeFile), FileMode.Create);
                    file.CopyTo(stram);
                    Console.WriteLine("------Ci siamooooooo-----File Copiato " + path+NomeFile);
                    return NomeFile;
//throw new NotImplementedException();
                }

        // cerca e ritorna un immagine nella tabella
        public async Task approva(Guid IDUSER, Guid IDFOto)
        {

            User utente =await  BaseDati.Users.FindAsync(IDUSER);

            Image foto = await BaseDati.Images.FindAsync(IDFOto);
            foto.ApprovedOn = DateTime.Today;
            foto.ApprovedBy = utente;
            foto.State = _State.Approved;

            await BaseDati.SaveChangesAsync();

        }

    }

}
