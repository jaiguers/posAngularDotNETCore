using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AntojitoModel.Model
{
    [Table("Rol")]
    public partial class Rol
    {
        public Rol()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long StateId { get; set; }
        public virtual ICollection<Rol_Actions> Rol_Actions { get; set; }
        public virtual ICollection<User_Rol> User_Rol { get; set; }
    }
}
