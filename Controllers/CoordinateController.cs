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
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    public class CoordinateController : ControllerBase
    {
        private readonly IServiceCoordinate _Coordinata;

        public CoordinateController(IServiceCoordinate coordinata)
        {
            _Coordinata = coordinata;
        }
        /*
        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] Coordinate cod)
        {

            _Coordinata.Add(cod);
            return Ok();
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<IActionResult> AddRange([FromBody] List<Coordinate> valori)
        {
     
            _Coordinata.AddRangeAsync(valori);
          
            return Ok();
        }

        [HttpPost]
        [Route("AddRangeArray")]
        public async Task<IActionResult> AddRange([FromBody] List<float> valori)
        {

            List<Coordinate> x = new List<Coordinate>();

             var z   = valori.Select(i => new Coordinate() {  Point = i }).ToList();
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

        */
    }
}
