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
    public class ProductController : Controller
    {
        private readonly IProductService prodService;

        public ProductController(IProductService thisServices)
        {
            prodService = thisServices;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return prodService.GetAllProduct();
        }

        [HttpPost]
        public bool SaveState([FromBody]ProductDTO pro)
        {
            return prodService.SaveProduct(pro);
        }
    }
}
