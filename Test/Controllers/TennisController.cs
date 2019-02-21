using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Interface;
using Test.Models;

namespace Test.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TennisController : ControllerBase
    {
        ITennisRepository _ITennisRepository;
        public TennisController(ITennisRepository itennisRepository)
        {
            _ITennisRepository = itennisRepository;
        }
        // GET api/values
        [HttpGet]
        public List<TennisModel> Get()
        {
            return _ITennisRepository.tennisPlayers().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<TennisModel> Get(int id)
        {
            return _ITennisRepository.tennisPlayers().Where(x=>x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}