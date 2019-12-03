using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class Sales
    {
        public Sales()
        {
        }

        public long Id { get; set; }

        public long ClientId { get; set; }

        public long UserId { get; set; }

        public string Code { get; set; }

        public decimal Iva { get; set; }

        public decimal NetoWorth { get; set; }

        public decimal Total { get; set; }

        public DateTime CreationDate { get; set; }

        public long PaymentMethodId { get; set; }

        public virtual Client Client { get; set; }
    }
}
