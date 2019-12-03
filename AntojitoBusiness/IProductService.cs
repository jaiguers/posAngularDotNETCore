using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using AntojitoModel.DTO;

namespace AntojitoBusiness
{
    public interface IProductService
    {
        bool SaveProduct(ProductDTO prod);
        List<Product> GetAllProduct();
    }
}
