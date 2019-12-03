using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AntojitoModel.Model
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public long CategoryId { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }

        public long Stock { get; set; }

        public DateTime CreationDate { get; set; }

        public long Purchased { get; set; }
    }
}
