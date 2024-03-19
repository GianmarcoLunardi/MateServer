using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services;
using MakeSense.Services.Interface;

namespace MakeSense.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ServiceAnnotation _Annotation;
        private readonly IServiceCoordinate _Coordinata;
        public InfoController(IServiceCoordinate Coo)
        {
            _Coordinata = Coo;
        }


        /*
                     services.AddTransient<IServiceAnnotation, ServiceAnnotation>();
        services.AddTransient<IServiceCategory, ServiceCategory>();
        services.AddTransient<IServiceCoordinate, ServiceCoordinate>();
        services.AddTransient<IServiceSegmentation, ServiceSegmentation>(); 
         */

        // POST api/info
        [HttpPost]
       [Route("Coordinata/Add")]
        public IActionResult Add([FromBody] Coordinate cod)
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
            Console.WriteLine("---------------------Entrata chiamata----------------------");
            _Coordinata.Add(cod);
            return Ok();
        }



        // POST api/bookchapters
        [HttpPost]
        [Route("Add")]
        public  IActionResult Add([FromBody] Info valore)
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
         /// Console.WriteLine("---------------------Entrata chiamata----------------------");
            //_Coordinata.Add();
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
