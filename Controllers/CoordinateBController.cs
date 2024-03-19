using MakeSense.Models;
using MakeSense.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeSense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinateBController : ControllerBase
    {
        private readonly IServiceCoordinateB _Coordinata;

        public CoordinateBController(IServiceCoordinateB coordinata)
        {
            _Coordinata = coordinata;
        }

        [HttpPost]
        [Route("AddRange")]
        public async Task<IActionResult> AddRange([FromBody] List<CoordinateB> valori)
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
            //_Coordinata.AddRangeAsync();
            return Ok();
        }

    }
}
