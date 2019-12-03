namespace AntojitosModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rol_Actions
    {
        public long Id { get; set; }

        public long RolId { get; set; }

        public long ActionId { get; set; }

        public virtual Actions Actions { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
