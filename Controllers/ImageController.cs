using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Services.Interface;
using MakeSense.Models.DTO.InComing;
using MakeSense.Models;
using AutoMapper;
using System.IO;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.StaticFiles;
using MakeSense.Models.DTO.OutComing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeSense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IServiceImage service;

        // DI AutoMapper
        private readonly IMapper mapper;

        public ImageController(IServiceImage _service, IMapper _mapper)
        {
            this.service = _service;
            this.mapper = _mapper;
        }

        /*
// GET: api/<ImageController>
[HttpGet]
public IEnumerable<string> Get()
{
   return new string[] { "value1", "value2" };
}
*/


        [HttpGet]
        [Route("MetteLoStatoTrueUpload")]
        public async Task<IActionResult> UploadTrue()
        {
            await service.ResetUpload();
            return Ok();
        }

        /// <summary>
        /// Restitutisce una colleziobe di oggetti immagine
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <response code="200">Product created</response>
        /// <response code="400">Product has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your product right now</response>


        [HttpGet]
        [Route("List")]
         public IActionResult List()
        {
            
            return Ok( service.List());
        }


        // Fa il download del file il cui nome è

        // Ritorna La Foto
        // GUID
        // "bc58bc5c-cc3c-4c2e-87eb-002ba689b083"
        // C:\Users\Gianmarco\Documents\C\MakeSense\Foto\oral_img-2024513--.jpg
        //
        // https://www.youtube.com/watch?v=xZV42p9QCh8
        [HttpGet]
        [Route("GetFotoDownload/{id}")]
        public async Task<IActionResult> GetFoto(Guid id)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Foto");
            //string NomeFile = "oral_img-2024513--.jpg";
            string NomeFile = await service.GetNameFoto( id );
            //string NomeFile = ba
            
            string PathFile = Path.Combine(path, NomeFile);

            
           // Console.WriteLine("Dentro il service");


            //Path.Combine(path, NomeFile);
            //return Ok(await service.GetFoto(id));
            //return null;


            //Download Del File
           
            

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(PathFile, out var contenttype))
            {
                contenttype = "application/octet-stream";
            }

            var bytes = await System.IO.File.ReadAllBytesAsync(PathFile);
            return File(bytes, contenttype, Path.GetFileName(PathFile));
         


           // return  Ok(PathFile);
        }

        /// <summary>
        /// Re
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        /// service che dato un guid restitutisce un oggetto imabve

        [HttpGet]
        [Route("GetFotoApproved/{id}/{id2}")]
        [ProducesResponseType(200)]

        public async Task<IActionResult> GetFotoAproved(Guid id , 
            Guid  id2 )
        {
           // id Guid User    d3dcb476-8028-4821-3790-08dc8ed97b37
            //id2 Guid Foto      bc58bc5c-cc3c-4c2e-87eb-002ba689b083
            



            //id = Guid.Parse("bc58bc5c - cc3c - 4c2e-87eb-002ba689b083");
            //id2 = Guid.Parse("d3dcb476-8028-4821-3790-08dc8ed97b37");

            // mapper.Map<Image>(request);

            // return Ok(await service.GetFoto(id));

            await service.approva(id, id2);
            return Ok();
        }


        [HttpGet]
        [Route("GetFotoDetail/{id}")]
        public async Task<IActionResult> GetFotoDetal(Guid id)
        {

            // mapper.Map<Image>(request);

          // return Ok(await service.GetFoto(id));

            return Ok( mapper.Map<ImageDetailOutDto>( await service.GetFoto(id)) );
        }




        [HttpGet]
        [Route("GetFotoDetai/{id}")]
        public async Task<IActionResult> GetFotoDeta(Guid id)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Foto");
            //string NomeFile = "oral_img-2024513--.jpg";
            string NomeFile = await service.GetNameFoto(id);
            //string NomeFile = ba

            string PathFile = Path.Combine(path, NomeFile);


            // Console.WriteLine("Dentro il service");


            //Path.Combine(path, NomeFile);
            //return Ok(await service.GetFoto(id));
            //return null;


            //Download Del File



            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(PathFile, out var contenttype))
            {
                contenttype = "application/octet-stream";
            }

            var bytes = await System.IO.File.ReadAllBytesAsync(PathFile);
            return File(bytes, contenttype, Path.GetFileName(PathFile));



             return  Ok(PathFile);
        }


        /*




        // GET api/<ImageController>/5 [Consumes("multipart/form-data")]

        [Consumes("multipart/form-data")]
        // [HttpGet("{id}")]
        //[Route("DownloadFoto")]
       
        [HttpGet]
        //[Route("Download/{id}")]
        public async Task<IActionResult> DownloadFoto()
        {
            
            return null;
        }
        /*
        // POST api/<ImageController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
        //async Task<IActionResult>
        // POST api/<ImageController>

        // api che prende un oggetto 
        /// <summary>
        /// Api per l innserimento di un file dentro la base date
        /// </summary>
        /// <param name="request"> Oggetto di tipo ImageIn  </param>
        /// <returns>Stato 200 nel caso l nseriemento dei dato p andato a buon fine</returns>
        /// 




        [Consumes("multipart/form-data")]
        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("UploadJson")]
        public async Task<IActionResult> UploadFileProva25(IFormFile json )
        {
            await service.UploadJson(json);



            // ImageIn x = new ImageIn();
            // x.File = Immagine;
            //  string FileSalvato = await service.UploadFileMulti(x);



            return Ok(json);
        }








        [Consumes("multipart/form-data")]
        [HttpPost]
        [Route("UploadFoto")] 
        public async Task<IActionResult> UploadFile(
            [FromForm] ImageIn request

            )
        {

            // https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-8.0


           

            //La procedura Fa salva l immagine Poi restitutisce il nome del fali secondo 
            // la convenzione
            string FileSalvato = await service.UploadFileMulti(request);
            

             Image Immagine = mapper.Map<Image>(request);
            Immagine.File_Name = FileSalvato;



            //restitutisce lestenzione della figura +++Aggiouger
            Immagine.Format = Path.GetExtension(request.File.FileName);


            //++Aggiunger
            Immagine.Size = request.File.Length / 1024;// IList risultato saqrà esperesso in kb

            // imposta lo stato a uploaded
            Immagine.State = _State.uploaded;
            // per ottenere inveve il risultato in mega nitr    1024*1024 ;
            // Non lo prendere

            service.Add(Immagine);

            
            return Ok();
            
        }




    }
}
