using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AntojitoModel.Model
{
    public partial class Users
    {
        public Users()
        {

        }

        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long StateId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
