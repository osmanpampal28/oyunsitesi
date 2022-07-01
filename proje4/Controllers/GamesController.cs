using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace proje4.Controllers
{
    public class GamesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET : Blogs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Games.Include(x => x.Developer).Include(y => y.Category).Include(z => z.GameGalleries);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult FilterByCategory()
        {
            List<Game> games = _context.Games.Include(x => x.Developer).Include(y => y.Category).Include(z => z.GameGalleries).ToList();
            var filter = _context.Games.OrderBy(t => t.Category.CategoryName).ToList();
            return View(filter);
        }

        public IActionResult FilterByYearAscending()
        {
            List<Game> games = _context.Games.Include(x => x.Developer).Include(y => y.Category).Include(z => z.GameGalleries).ToList();
            var filter = (from t in _context.Games
                          orderby t.Year ascending
                          select t).ToList();
            return View(filter);
        }
        public IActionResult FilterByYearDescending()
        {
            List<Game> games = _context.Games.Include(x => x.Developer).Include(y => y.Category).Include(z => z.GameGalleries).ToList();
            var filter = _context.Games.OrderByDescending(t => t.Year).ToList();
            return View(filter);
        }
        public IActionResult FilterByPointAscending()
        {
            List<Game> games = _context.Games.Include(x => x.Developer).Include(y => y.Category).Include(z => z.GameGalleries).ToList();
            var filter = (from t in _context.Games
                          orderby t.Point
                          select t).ToList();
            return View(filter);
        }
        public IActionResult FilterByPointDescending()
        {
            List<Game> games = _context.Games.Include(x => x.Developer).Include(y => y.Category).Include(z => z.GameGalleries).ToList();
            var filter = _context.Games.OrderByDescending(t => t.Point).ToList();
            return View(filter);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .Include(b => b.Category)
                .Include(c => c.GameGalleries)
                .Include(b => b.Developer)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }
        
    }
}
