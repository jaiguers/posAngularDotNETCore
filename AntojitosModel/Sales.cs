namespace AntojitosModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sales()
        {
            Sales_Detail = new HashSet<Sales_Detail>();
        }

        public long Id { get; set; }

        public long ClientId { get; set; }

        public long UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NetoWorth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        public DateTime CreationDate { get; set; }

        public long PaymentMethodId { get; set; }

        public virtual Client Client { get; set; }

        public virtual PaymentMethods PaymentMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Detail> Sales_Detail { get; set; }

        public virtual Users Users { get; set; }
    }
}
