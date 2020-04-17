using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Database;
using UserService.Database.Entity;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DatabaseContext db;

        public UserController()
        {
            db = new DatabaseContext();
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> lstUser = new List<User>();

            User u3 = new User
            {
                UserId = 103,
                Name = "Bam",
                Address = "Bangalore"
            };
            User u2 = new User
            {
                UserId = 101,
                Name = "Pam",
                Address = "Bangalore"
            };
            User u1 = new User {
                UserId = 100,
                Name="Sam",
                Address="Bangalore"
            };

            lstUser.Add(u1);
            lstUser.Add(u2);
            lstUser.Add(u3);

            return lstUser;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
