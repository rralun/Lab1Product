using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Laborator1Product.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Watch",
                    Description = "Men`s watch - Hybrid",
                    Category = "SmartWatch",
                    Price = 235
                },
                new Product
                {
                    Name = "T-shirt",
                    Description = "Cotton t-shirt for woman",
                    Category = "Clothes",
                    Price = 25
                }
            );
            context.SaveChanges();
        }
    }
}
