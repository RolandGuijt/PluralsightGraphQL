using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRock.Api.Data.Entities;

namespace CarvedRock.Api.Data
{
    public static class InitialData
    {
        public static void Seed(this CarvedRockDbContext dbContext)
        {
            if (!dbContext.Products.Any())
            {
                dbContext.Products.Add(new Product
                {
                    Name = "Mountain Walkers",
                    Description = "Use these sturdy shoes to pass any mountain range with ease.",
                    Price = 219.5m,
                    Rating = 4,
                    Type = ProductType.Boots,
                    Stock = 12,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Army Slippers",
                    Description = "For your everyday marches in the army.",
                    Price = 125.9m,
                    Rating = 3,
                    Type = ProductType.Boots,
                    Stock = 56,
                    PhotoFileName = "shutterstock_222721876.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Backpack Deluxe",
                    Description = "This backpack can survive any tornado.",
                    Price = 199.99m,
                    Rating = 5,
                    Type = ProductType.ClimbingGear,
                    Stock = 66,
                    PhotoFileName = "shutterstock_6170527.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Climbing Kit",
                    Description = "Anything you need to climb the mount Everest.",
                    Price = 299.5m,
                    Rating = 5,
                    Type = ProductType.ClimbingGear,
                    Stock = 3,
                    PhotoFileName = "shutterstock_48040747.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Blue Racer",
                    Description = "Simply the fastest kayak on earth and beyond for 2 persons.",
                    Price = 350m,
                    Rating = 5,
                    Type = ProductType.Kayaks,
                    Stock = 8,
                    PhotoFileName = "shutterstock_441989509.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Orange Demon",
                    Description = "One person kayak with hyper boost button.",
                    Price = 450m,
                    Rating = 2,
                    Type = ProductType.Kayaks,
                    Stock = 1,
                    PhotoFileName = "shutterstock_495259978.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.SaveChanges();
            }
        }
    }
}
