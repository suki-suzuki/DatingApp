

using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        public DataContext _context { get; }

        public UsersController(DataContext context)
        {
            _context = context;
            
        }
       [HttpGet]
       public async Task< ActionResult<IEnumerable<AppUser>>>GetUser()
       {
            var users= await _context.Users.ToListAsync();
           
            return users;
       }
       [HttpGet("{id}")]
       public async Task< ActionResult<AppUser>> GetUser(int id){
            
            return await _context.Users.FindAsync(id);
            
       }
    }
}