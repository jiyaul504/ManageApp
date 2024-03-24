using ManageApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageApp.Controllers.APIController
{
    [Produces("application/json")]
    [Route("api/Contact")]
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Contact
        [HttpGet]
        public async Task<ActionResult<object>> GetContacts()
        {
            List<Contact> Items = await _context.Contacts.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }
    }
}
