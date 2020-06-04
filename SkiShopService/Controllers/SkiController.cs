using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkiShopService.Model;


namespace SkiShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkiController : ControllerBase
    {
        private static readonly List<Ski> skis = new List<Ski>()
        {
            new Ski(1, 200, "Slalom", 5000),
            new Ski(2, 190, "Slalom", 4500),
            new Ski(3, 180, "CrossCountry", 3500),
            new Ski(4, 170, "Freestyle", 4000),
            new Ski(5, 190, "Downhill", 5000),
        };


        // GET: api/Ski
        [HttpGet]
        public IEnumerable<Ski> Get()
        {
            return skis;
        }

        // GET: api/Ski/5
        [HttpGet("{id}", Name = "Get")]
        public Ski Get(int id)
        {
            return skis.Find(i => i.Id == id);
        }

        [HttpGet]
        [Route("skitype/{substring}")]
        public IEnumerable<Ski> GetFromSubstring(string substring)
        {
            return skis.FindAll(i => i.SkiType.Contains(substring));
        }

        // POST: api/Ski
        [HttpPost]
        public void Post([FromBody] Ski value)
        {
            skis.Add(value);
        }



        //// PUT: api/Ski/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Ski value)
        //{
        //    Ski ski = Get(id);
        //    if (ski != null)
        //    {
        //        ski.Id
        //    }
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
