using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts.Dto;

namespace Web.Controllers
{

    [Route("api/admin/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<User> Find()
        {
            return new[]
            {
                new User { Id = 0, FirstName = "Hem", LastName = "Talreja" },
                new User { Id = 1, FirstName = "Jeff", LastName = "Stansberry" },
            };
        }
        

        public User Get(int id)
        {
            return new User { Id = id, FirstName = "First Name", LastName = "Last Name" };
        }
        
    }

}
