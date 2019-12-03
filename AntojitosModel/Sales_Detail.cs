namespace AntojitosModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales_Detail
    {
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long SaleId { get; set; }

        public DateTime SaleDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual Sales Sales { get; set; }
    }
}
