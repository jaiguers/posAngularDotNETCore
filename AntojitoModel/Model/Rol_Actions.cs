using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class Rol_Actions
    {
        public long Id { get; set; }
        public long RolId { get; set; }
        public long ActionId { get; set; }
        public virtual Actions Actions { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
