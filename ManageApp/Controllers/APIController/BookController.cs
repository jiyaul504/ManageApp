using ManageApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManageApp.Controllers.APIController
{
    [Produces("application/json")]
    [Route("api/Book")]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<object>> GetBooks()
        {
            List<Book> Items = await _context.Books.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }
    }
}
