using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoModel.DTO
{
    public class ProductDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public string PurchasePrice { get; set; }
        public string SalePrice { get; set; }
        public string Stock { get; set; }
        public string Purchased { get; set; }
    }
}
