using System;
using System.Collections.Generic;
using System.Text;
using AntojitoModel;
using AntojitoModel.Model;
using System.Linq;

namespace AntojitoBusiness
{
    public class CategoryService : ICategoryService
    {
        private readonly AntojoDbContext context;

        public CategoryService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public List<Product_Category> GetAllCategory()
        {
            try
            {
                return context.Product_Category.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
