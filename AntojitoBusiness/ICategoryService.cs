using AntojitoModel.DTO;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoBusiness
{
    public interface ICategoryService
    {
        List<Product_Category> GetAllCategory();
    }
}
