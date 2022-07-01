using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace proje4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperApiController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public DeveloperApiController(ApplicationDbContext _obj)
        {
            this._context = _obj;
        }

        // GET: api/<DeveloperApiController>
        [HttpGet]
        public List<Developer> Get()
        {
            return _context.Developers.ToList();
        }

        // GET api/<DeveloperApiController>/5
        [HttpGet("{id}")]
        public Developer Get(int id)
        {
            var y = _context.Developers.FirstOrDefault(x => x.DeveloperId == id);
            return y;
        }

        // POST api/<DeveloperApiController>
        [HttpPost]
        public void Post([FromBody] Developer value)
        {
            _context.Developers.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<DeveloperApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Developer value)
        {
            var y1 = _context.Developers.FirstOrDefault(x => x.DeveloperId == id);

            if (y1 is null)
                return NotFound();
            else
            {
                y1.DeveloperCompanyName = value.DeveloperCompanyName;
                y1.Logo = value.Logo;
                _context.Update(y1);
                _context.SaveChanges();
                return Ok();
            }
        }

        // DELETE api/<DeveloperApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var y1 = _context.Developers.FirstOrDefault(x => x.DeveloperId == id);

            if (y1 is null)
                return NotFound();
            else
            {
                _context.Remove(y1);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
