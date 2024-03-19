using MakeSense.Models;
using MakeSense.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoordinateController : ControllerBase
    {
        private readonly IServiceCoordinate _Coordinata;

        public CoordinateController(IServiceCoordinate coordinata)
        {
            _Coordinata = coordinata;
        }

        [HttpPost]
        [Route("Add")]
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

        [HttpPost]
        [Route("AddRange")]
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

        [HttpPost]
        [Route("AddRangeArray")]
        public async Task<IActionResult> AddRange([FromBody] List<float> valori)
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
            List<Coordinate> x = new List<Coordinate>();

             var z   = valori.Select(i => new Coordinate() { Id = 0 , Point = i }).ToList();
            // valori.Select(i => new { id = "0", point = i });
            //  Coordinate x = valori.Select(i => new Coordinate().);
             _Coordinata.AddRangeAsync(z);
            // _Coordinata.AddRangeAsync();
            return Ok();
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return null;
        }


    }
}
