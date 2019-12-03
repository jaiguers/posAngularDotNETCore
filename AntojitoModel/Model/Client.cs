using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AntojitoModel.Model
{
    [Table("Client")]
    public partial class Client
    {
        public Client()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Identification { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public long StateId { get; set; }

        public DateTime Creationdate { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
