using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FloridaRecycling_Db_API.Services.Repository;
using FloridaRecycling_Db_API.Models;

namespace FloridaRecycling_Db_API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IFloridaRecyclingDbRepository _repository;

        public ValuesController(IFloridaRecyclingDbRepository repository) {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Metals>> Get()
        {
            //return new string[] { "value1", "value2" };
            return await _repository.GetMetalsAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
