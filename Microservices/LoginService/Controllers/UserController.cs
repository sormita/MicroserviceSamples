using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using LoginService.Entities;
using LoginService.Model;
using LoginService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginService.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IPersonRepository repos;
        private readonly IMapper mapper;

        public UserController(IPersonRepository irepos, IMapper imapper)
        {
            repos = irepos;
            mapper = imapper;
        }
        //// GET: api/User
        //[HttpGet]
        //public IEnumerable<User> Get()
        //{
        //    List<User> lstUser = new List<User>();

        //    User u3 = new User
        //    {
        //        UserId = 103,
        //        Name = "Bam",
        //        Address = "Bangalore"
        //    };
        //    User u2 = new User
        //    {
        //        UserId = 101,
        //        Name = "Pam",
        //        Address = "Bangalore"
        //    };
        //    User u1 = new User
        //    {
        //        UserId = 100,
        //        Name = "Sam",
        //        Address = "Bangalore"
        //    };

        //    lstUser.Add(u1);
        //    lstUser.Add(u2);
        //    lstUser.Add(u3);

        //    return lstUser;
        //}

        // GET: api/User/GetUserWithId
        //[Route("GetUserWithId")]
        //[HttpGet]
        //public User GetUser(int id)
        //{
        //    List<User> lstUser = new List<User>();

        //    User u3 = new User
        //    {
        //        UserId = 103,
        //        Name = "Bam",
        //        Address = "Bangalore"
        //    };
        //    User u2 = new User
        //    {
        //        UserId = 101,
        //        Name = "Pam",
        //        Address = "Bangalore"
        //    };
        //    User u1 = new User
        //    {
        //        UserId = 100,
        //        Name = "Sam",
        //        Address = "Bangalore"
        //    };

        //    lstUser.Add(u1);
        //    lstUser.Add(u2);
        //    lstUser.Add(u3);

        //    User usrObj = lstUser.Where(x => x.UserId.Equals(id)).FirstOrDefault();

        //    return usrObj;
        //}

        // GET: api/User/GetUserWithId
        [HttpGet]
        public User GetUser(string email,string password)
        {
            var lstUser = repos.GetLoginUser(email, password);

            Person usrObj = lstUser
                .FirstOrDefault();

            User usr = mapper.Map<User>(usrObj);

            return usr;
        }
    }
}