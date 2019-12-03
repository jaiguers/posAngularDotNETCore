using AntojitoBusiness;
using AntojitoModel.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace AntojitosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("currentPol")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService catService;

        public CategoryController(ICategoryService thisService)
        {
            catService = thisService;
        }

        [HttpGet]
        public List<Product_Category> Get()
        {
            return catService.GetAllCategory();
        }
    }
}
