using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Models.DTO.InComing;

using MakeSense.Services;
using MakeSense.Services.Interface;
using AutoMapper;
using MakeSense.Models.DTO.input;

using System.Text.Json;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace MakeSense.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly Context BaseDati;
        private readonly ServiceAnnotation _Annotation;
        private readonly IServiceCoordinate _Coordinata;
        private readonly IMapper _mapper;
        private readonly IServiceInfo ServiceInfo;

        public InfoController(IServiceCoordinate Coo, IMapper mapper, 
            IServiceInfo _ServiceInfo,
            Context _BasiDati)
        {
            _Coordinata = Coo;
            _mapper = mapper;
            BaseDati = _BasiDati;
            ServiceInfo = _ServiceInfo;
        }

        [HttpPost]
        [Route("uploadJson")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpJson(IFormFile file)
        {


            await ServiceInfo.UploadJson(file);
            return Ok();
        }


        // Getall api/info
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("All")]
        public IActionResult All()
        {
            var x = BaseDati.roots.Include(x => x.images);
           
            Console.WriteLine("---------------------Entrata chiamata----------------------");
           // _Coordinata.Add(cod);
            return Ok( x );
        }



        /*
                     services.AddTransient<IServiceAnnotation, ServiceAnnotation>();
        services.AddTransient<IServiceCategory, ServiceCategory>();
        services.AddTransient<IServiceCoordinate, ServiceCoordinate>();
        services.AddTransient<IServiceSegmentation, ServiceSegmentation>(); 
         */

    





        // POST api/bookchapters
        [HttpPost]
        [Route("Add")]
        public  IActionResult Add([FromBody] CocoJsonRequest valore)
        {

             Console.WriteLine("---------------------Entrata chiamata----------------------");

            return Ok();
        }

        [HttpPost]
        [Route("Coordinate/AddRange")]
        public async Task<IActionResult> AddRange([FromBody] List<Coordinate> valori)
        {
            /*
            if (chapter == null)
             {
                 return BadRequest();
             }
             _bookChaptersService.Add(chapter);
             return CreatedAtRoute(nameof(GetBookChapterById), new { id = chapter.Id },
             chapter);
            */
            _Coordinata.AddRangeAsync(valori);
            // _Coordinata.AddRangeAsync();
            return Ok();
        }



        // GET: InfoController/Create
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<Annotation>> Create(annotation a)
        {
            Console.WriteLine("Ciaoo00");
            var xx = _mapper.Map<Annotation>(a);

          //  Console.WriteLine("-------->" + xx.Segmentations.Count() );
            

            return Ok();
        }




        /*
       

        // GET: InfoController/Details/5
        public ActionResult Details(int id)
        {
            return null;
        }

        // GET: InfoController/Create
        public ActionResult Create()
        {
            return null;
        }

        // POST: InfoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return null;
            }
        }

        // GET: InfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return null;
        }

        // POST: InfoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return null;
            }
        }

        // GET: InfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return null;
        }
        
        // POST: InfoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return null;
            }
        }
        */
    }
}
