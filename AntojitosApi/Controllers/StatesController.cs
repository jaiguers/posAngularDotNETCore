using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AntojitoBusiness;
using AntojitoModel.Model;
using Microsoft.AspNetCore.Cors;

namespace AntojitosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("currentPol")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IStateService stService;

        public StatesController(IStateService stateServices)
        {
            stService = stateServices;
        }

        [HttpGet]
        public List<States> Get()
        {
            return stService.GetAllStates();
        }

        [HttpPost]
        public bool SaveState(States states)
        {
            return stService.SaveState(states);
        }




    }
}