using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class PaymentMethods
    {
        public PaymentMethods()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long StateId { get; set; }

    }
}
