using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoModel.DTO
{
    public class SaleDTO
    {
        public long Id { get; set; }

        public long ClientId { get; set; }
        public string ClientName { get; set; }

        public long UserId { get; set; }
        public string UserName { get; set; }

        public string Code { get; set; }

        public decimal Iva { get; set; }

        public decimal NetoWorth { get; set; }
        public decimal Total { get; set; }
        public long PaymentMethodId { get; set; }
        public string PaymentName { get; set; }
        public string Details { get; set; }
    }
}
