using ECart.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECart.Domain.Models;

namespace ECart.DbAccess
{
    public class ECartContext:DbContext, IEcartContext
    {
        public ECartContext() : base(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Ecart119;Integrated Security=True") {

        }

        public DbSet<Checkout> Checkouts
        {
            get;set;
        }

        public DbSet<CheckoutSummery> CheckoutSummerys
        {
            get;set;
        }

        public DbSet<Error> Errors
        {
            get;set;
        }

        public DbSet<Item> Items
        {
            get;set;
        }

        public DbSet<User> Users
        {
            get;set;
        }
    }
}
