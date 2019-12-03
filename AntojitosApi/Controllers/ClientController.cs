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
    public class ClientController : Controller
    {
        private readonly IClientService cltService;

        public ClientController(IClientService thisServices)
        {
            cltService = thisServices;
        }

        [HttpGet]
        public List<Client> Get()
        {
            return cltService.GetAllClient();
        }

        [HttpPost]
        public bool SaveClient([FromBody]ClientDTO client)
        {
            return cltService.SaveClient(client);
        }
    }
}
