using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FloridaRecycling_Db_API.Services.Repository;
using FloridaRecycling_Db_API.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FloridaRecycling_Db_API.Controllers {
    [Route("api/[controller]")]
    public class MetalController : Controller {
        private IFloridaRecyclingDbRepository _repository;

        public MetalController(IFloridaRecyclingDbRepository repository) {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public Task<IEnumerable<Metals>> Get() {
            return _repository.GetMetalsAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Task<Metals> Get(int id) {
            return _repository.GetMetalAsync(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        //[HttpGet("{id}")]
        //public async Task<Metals> Get(int id) {
        //    string filePath = "C:\\Users\\DanJ2\\OneDrive\\WebSite HTML Files\\Florida Recycling Site\\escrap.jpg";
        //    var metal = await _repository.GetMetalAsync(id);
        //    using (var stream = new FileStream(filePath, FileMode.Open)) {
        //        byte[] byteImage = new byte[stream.Length];
        //        await stream.ReadAsync(byteImage, 0, (int)stream.Length);
        //        metal.CommodityImage = byteImage;
        //        await _repository.SaveChangesAsync();
        //    }
        //    return metal;
        //}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
