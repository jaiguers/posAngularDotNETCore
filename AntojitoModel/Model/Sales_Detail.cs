using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class Sales_Detail
    {
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long SaleId { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
