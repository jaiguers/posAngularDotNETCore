using AntojitoModel;
using AntojitoModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AntojitoModel.DTO;

namespace AntojitoBusiness
{
    public class ProductService : IProductService
    {
        private readonly AntojoDbContext context;

        public ProductService(AntojoDbContext thisContext)
        {
            context = thisContext;
        }

        public bool SaveProduct(ProductDTO prodDTO)
        {
            try
            {
                Product prod = new Product
                {
                    Name = prodDTO.Name,
                    CategoryId = long.Parse(prodDTO.CategoryId),
                    Code = prodDTO.Code,
                    Image = prodDTO.Image,
                    PurchasePrice = decimal.Parse(prodDTO.PurchasePrice),
                    SalePrice = decimal.Parse(prodDTO.SalePrice),
                    Stock = long.Parse(prodDTO.PurchasePrice),
                    Purchased = long.Parse(prodDTO.Purchased),
                    CreationDate = DateTime.Now,
                };

                context.Product.Add(prod);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public List<Product> GetAllProduct()
        {
            try
            {
                return context.Product.Where(j => j.Stock > 0).Select(j => new Product
                {
                    Id = j.Id,
                    Name = j.Name,
                    Code = j.Code,
                    Image = j.Image,
                    PurchasePrice = j.PurchasePrice,
                    SalePrice = j.SalePrice,
                    Stock = j.Stock,
                    Purchased = j.Purchased
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
