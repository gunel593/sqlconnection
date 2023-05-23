using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static int count = 1;
        private static readonly List<User> users = new List<User>();
        [HttpPost("created")]
        public string Create(string Name, string Surname)
        {
            User user = new User()
            {
                Id = count++,
                Username = Name,
                Fullname = Surname,


            };
            users.Add(user);
            return $"\"{Name},{Surname}\"created"; ;
        }
        [HttpGet]
      
            public User GetUserId(int Id)
            {
                var user= users.FirstOrDefault(user => user.Id == Id);
               
                return user;
            }
        }
    }

