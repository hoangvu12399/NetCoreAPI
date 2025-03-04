using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index4()
        {
            var model = await _context.Persons.ToListAsync();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }   

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,Fullname,Address")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index4));
            }
            return View(person);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var person = await _context.Persons.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,Fullname,Address")] Person person)
        {
            if (id != person.PersonID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.PersonID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index4));
            }
            return View(person);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var person = await _context.Persons.FirstOrDefaultAsync(m => m.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Persons == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Persons' is null.");
            }
            var person = await _context.Persons.FindAsync(id);
            if (person != null)
            {
                _context.Persons.Remove(person);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index4));
        }

        private bool PersonExists(string id)
        {
            return _context.Persons.Any(e => e.PersonID == id);
        }

        // public IActionResult Index3()
        // {
        //     return View();
        // } 

        // public IActionResult Welcome3()
        // {
        //     return View();
        // }
        // public IActionResult Index()
        // {
        //     return View();
        // } 
        // [HttpPost]
        // public IActionResult Index(Person @ps)
        // {
        //     string strOutput = "Xin chào" + ps.PersonID + "-" + ps.Fullname + "-" + ps.Address;
        //     ViewBag.inforPerson = strOutput;
        //     return View();
        // }
    }
}
