namespace AntojitosModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Rol
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long RolId { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Users Users { get; set; }
    }
}
