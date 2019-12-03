namespace AntojitosModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Sales_Detail = new HashSet<Sales_Detail>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SalePrice { get; set; }

        public long Stock { get; set; }

        public DateTime CreationDate { get; set; }

        public long Purchased { get; set; }

        public virtual Product_Category Product_Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Detail> Sales_Detail { get; set; }
    }
}
