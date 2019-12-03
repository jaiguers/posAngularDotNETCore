using AntojitoModel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntojitoModel
{
    public partial class AntojoDbContext : DbContext
    {
        public AntojoDbContext(DbContextOptions<AntojoDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_Category> Product_Category { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rol_Actions> Rol_Actions { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Sales_Detail> Sales_Detail { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<User_Rol> User_Rol { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        

    }
}

