using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeSense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IServiceImage service;

        public ImageController(IServiceImage _service)
        {
            this.service = _service;
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
        public IActionResult Get()
        {
            
            return Ok("File Caricato");
        }




        // GET api/<ImageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            
            string controllo = await service.UploadFile(file);
            return Ok(controllo);
        }



        // PUT api/<ImageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
