using IceRoll.Models;
using Microsoft.EntityFrameworkCore;

namespace Rollice.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                        Id = 1,
                        Name = "Chocoa Ice.Roll",
                        Description = "Delicious chocolate that melts in the mouth",
                        Price = 24.000m,
                        ImageName = "chocoa.jpeg"
                },new Product
                {
                        Id = 2,
                        Name = "Banana Ice.Roll",
                        Description = "delicious bananas with unrivaled tenderness",
                        Price = 22.000m,
                        ImageName = "banana.jpeg"
                },new Product
                {
                        Id = 3,
                        Name = "Manggo Ice.Roll",
                        Description = "very tempting fragrance with fresh fruit",
                        Price = 26.000m,
                        ImageName = "manggo.jpeg"
                },new Product
                {
                        Id = 4,
                        Name = "orange Ice.Roll",
                        Description = "so tempting sweet with delicious taste",
                        Price = 23.000m,
                        ImageName = "orange.jpeg"
                },new Product
                {
                        Id = 5,
                        Name = "Oreo Ice.Roll",
                        Description = "So delicious crunchy",
                        Price = 28.000m,
                        ImageName = "oreo.jpeg"
                },new Product
                {
                        Id = 6,
                        Name = "Strawberry Ice.Roll",
                        Description = "delicious taste with fresh fruit topping",
                        Price = 26.000m,
                        ImageName = "strawberry.jpeg"
                }
            );
            return modelBuilder;
        }
    }
}
