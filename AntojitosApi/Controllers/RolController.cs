using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntojitoBusiness;
using AntojitoModel.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AntojitosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("currentPol")]
    public class RolController : Controller
    {
        private readonly IRolService rolService;

        public RolController(IRolService thisService)
        {
            rolService = thisService;
        }

        [HttpGet]
        public List<Rol> Get()
        {
            return rolService.GetAllRol();
        }
    }
}
