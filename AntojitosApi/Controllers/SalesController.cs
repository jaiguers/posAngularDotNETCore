using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntojitoBusiness;
using AntojitoModel.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AntojitosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("currentPol")]
    public class SalesController : Controller
    {
        private readonly ISaleService saleService;
        public SalesController(ISaleService thisServices)
        {
            saleService = thisServices;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<SaleDTO> Get()
        {
            return saleService.GetAllSale();
        }


        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody]SaleDTO sale)
        {
            try
            {
                saleService.SaveUser(new SaleDTO());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

    }
}
