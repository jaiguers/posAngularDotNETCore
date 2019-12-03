using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntojitoBusiness;
using AntojitoModel.DTO;
using AntojitoModel.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AntojitosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("currentPol")]
    public class UsersController : Controller
    {

        private readonly IUserService usService;
        public UsersController(IUserService thisServices)
        {
            usService = thisServices;
        }


        [HttpGet]
        public List<Users> Get()
        {
            return usService.GetAllUser();
        }

        [HttpPost]
        public bool SaveUser([FromBody] UserDTO user)
        {
            return usService.SaveUser(user);
        }

        [HttpPost]
        [Route("login")]
        public UserDTO Login([FromBody] UserDTO user)
        {
            return usService.Login(user);
        }
    }
}
