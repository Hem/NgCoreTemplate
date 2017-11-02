using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Contracts.Dto;

namespace Web.Controllers
{

    [Route("api/admin/[controller]")]
    public class UserController : Controller
    {
        readonly IUserRepository UserRepository;
        
        public UserController(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }


        [HttpGet("[action]")]
        public async Task<IEnumerable<User>> Find()
        {
            return await UserRepository.Find(null);
        }
        
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return new User { Id = id, FirstName = "First Name", LastName = "Last Name" };
        }
        
    }

}
