using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeSense.Models;
using MakeSense.Services;
using MakeSense.Services.Interface;

// utilizzo DTO
using AutoMapper;
using MakeSense.Models.DTO.OutComing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeSense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UserController : ControllerBase
    {
        private readonly IServiceUtente Service;
        private readonly IMapper _mapper;

        public  UserController(IServiceUtente service, IMapper mapper)
        {
            Service = service;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpGet]
        [Route("GetMenu")]
        public IActionResult GetMenu()
        {

            IList<GuidName> lst = new List<GuidName>();
            //IList<GuidName> xlst = paranLst;

            lst.Add(new GuidName("", "none"));

            // Console.WriteLine("menua lista");
            //lst =  ;
            var Rlst = lst.Concat(Service.menu());
            //return new string[] { "value1", "value2" };
            return Ok( Rlst );
            //return Ok(Service.ListUser());
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };

            return Ok(Service.ListUser());
        }

        [Route("user/GetAsync")]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            //return new string[] { "value1", "value2" };

            User[] c = await Service.ListAsyn();
            var d = c.Select(x => Mapper.Map<UserOutComingDto>(x) ).ToList();

            return Ok(d);


            // return Ok(await Service.ListAsyn());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(Service.Find(id));
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User  entity)
        {
            Console.WriteLine("ciao sono il controllo utente");
            Service.Add(entity);
            Console.WriteLine("Ciao Sono in Controller Utente-" + entity.FirstName);
          
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
