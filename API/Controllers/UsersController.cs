using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        
        public DataContext _context { get; }

        public UsersController(DataContext context)
        {
            _context = context;
            
        }
        [AllowAnonymous]
       [HttpGet]
       public async Task< ActionResult<IEnumerable<AppUser>>>GetUser()
       {
            var users= await _context.Users.ToListAsync();
           
            return users;
       }
       [Authorize]
       [HttpGet("{id}")]
       public async Task< ActionResult<AppUser>> GetUser(int id){
            
            return await _context.Users.FindAsync(id);
            
       }
    }
}