using ManageApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManageApp.Controllers.APIController
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<object>> GetProducts()
        {
            List<Product> Items = await _context.Products.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }
    }
}
