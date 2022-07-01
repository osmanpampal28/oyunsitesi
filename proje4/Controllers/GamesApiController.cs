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
    public class GamesApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesApiController(ApplicationDbContext _obj)
        {
            this._context = _obj;
        }

        // localhost(domain adresi)/api/controllername

        // GET: api/<GamesApiController>
        [HttpGet]
        public List<Game> Get()
        {
            //return new string[] { "value1", "value2" };
            return _context.Games.ToList();
        }

        // GET api/<GamesApiController>/5
        [HttpGet("{id}")]
        public Game Get(int id)
        {
            var y = _context.Games.FirstOrDefault(x => x.GameId == id);
            return y;
        }

        // POST api/<GamesApiController>
        [HttpPost]
        public void Post([FromBody] Game value)
        {
            _context.Games.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<GamesApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Game value)
        {
            var y1 = _context.Games.FirstOrDefault(x => x.GameId == id);

            if (y1 is null)
                return NotFound();
            else
            {
                y1.GameName = value.GameName;
                y1.CoverPhoto = value.CoverPhoto;
                y1.Description = value.Description;
                y1.Year = value.Year;
                y1.Point = value.Point;
                y1.DeveloperId = value.DeveloperId;
                y1.CategoryId = value.CategoryId;
                _context.Update(y1);
                _context.SaveChanges();
                return Ok();
            }
        }

        // DELETE api/<GamesApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var y1 = _context.Games.FirstOrDefault(x => x.GameId == id);

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
