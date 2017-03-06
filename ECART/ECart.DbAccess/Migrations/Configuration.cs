namespace ECart.DbAccess.Migrations
{
    using Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static Bo.Utility.Enums;
    internal sealed class Configuration : DbMigrationsConfiguration<ECart.DbAccess.ECartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ECart.DbAccess.ECartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Users.AddOrUpdate(
              new User { Id = 1, Email = "admin", Name = "Admin", UserType = UserType.Oparator, Password = "123", RegDate = DateTime.Today },
              new User { Id = 2, Email = "iamchamith", Name = "Chamith", UserType = UserType.Client, Password = "123", RegDate = DateTime.Today }
            );
            context.Items.AddOrUpdate(
               new Item { Id = 1, Category = Category.Camara, Image = "no.jpg", Name = "Apple", Price = 12.12M, Description = "Apple Description" },
             new Item { Id = 2, Category = Category.Phone, Image = "no.jpg", Name = "Apple", Price = 2.12M, Description = "Apple Description" },
             new Item { Id = 3, Category = Category.Phone, Image = "no.jpg", Name = "Samsung", Price = 1.12M, Description = "Samsung Description" },
             new Item { Id = 4, Category = Category.Phone, Image = "no.jpg", Name = "Nokia", Price = 0.12M, Description = "Nokia Description" },
             new Item { Id = 5, Category = Category.Phone, Image = "no.jpg", Name = "Microsoft", Price = 10.12M, Description = "Microsoft Description" },
             new Item { Id = 6, Category = Category.Phone, Image = "no.jpg", Name = "Apple", Price = 12.12M, Description = "Apple Description" },
             new Item { Id = 7, Category = Category.Laptop, Image = "no.jpg", Name = "Nexus", Price = 12.12M, Description = "Nexus Description" },
             new Item { Id = 8, Category = Category.Laptop, Image = "no.jpg", Name = "Panasonic", Price = 12.12M, Description = "Panasonic Description" },
             new Item { Id = 9, Category = Category.Laptop, Image = "no.jpg", Name = "Dell", Price = 12.12M, Description = "Dell Description" },
             new Item { Id = 10, Category = Category.Desktop, Image = "no.jpg", Name = "Hp", Price = 12.12M, Description = "Hp Description" }
           );
            //
        }
    }
}
