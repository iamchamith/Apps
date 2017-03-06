using ECart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Domain.Utility
{
    public interface IEcartContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<Checkout> Checkouts { get; set; }
        DbSet<CheckoutSummery> CheckoutSummerys { get; set; }
        DbSet<Error> Errors { get; set; }
    }
}
