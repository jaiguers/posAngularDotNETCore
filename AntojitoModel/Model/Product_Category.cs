using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class Product_Category
    {
        public Product_Category()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
    }
}
