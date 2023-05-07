using FinancelyAPI.Context;
using FinancelyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinancelyAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            var users = await _context.Users.Include(u => u.Cards).ThenInclude(c => c.Bills).ToListAsync();
            return users;
        }

        [HttpGet("{id}", Name="GetUser")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.Include(u => u.Cards).ThenInclude(c => c.Bills).FirstOrDefaultAsync(u => u.UserId== id);

            if (user == null){
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public ActionResult Post(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetUser", new { id = user.UserId }, User);
        }
    }
}

