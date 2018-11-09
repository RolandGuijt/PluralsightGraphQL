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
                    Type = ProductTypeEnum.Boots,
                    Stock = 12,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "Crossed the Himalayas",
                            Review = "First released almost 30 years ago, the Titan 26078 is a classic work boot. It’s also one of Timberland’s all time best sellers."
                        },
                        new ProductReview
                        {
                            Title = "Comfortable",
                            Review = "One of the most comfortable hiking boots available, each pair comes complete with the Power Fit Comfort System, designed to offer maximum support at key areas of your feet."
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Army Slippers",
                    Description = "For your everyday marches in the army.",
                    Price = 125.9m,
                    Rating = 3,
                    Type = ProductTypeEnum.Boots,
                    Stock = 56,
                    PhotoFileName = "shutterstock_222721876.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "Indestructible",
                            Review = "They have absolutely no break in period and can literally be worn to work the day that you get them."
                        },
                        new ProductReview
                        {
                            Title = "Safety toe",
                            Review = "The safety toe is made from an aluminium alloy which offers all the protection of steel but half the weight. The soles are also oil, abrasion and slip resistant."
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Backpack Deluxe",
                    Description = "This backpack can survive any tornado.",
                    Price = 199.99m,
                    Rating = 5,
                    Type = ProductTypeEnum.ClimbingGear,
                    Stock = 66,
                    PhotoFileName = "shutterstock_6170527.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "Feels like canvas",
                            Review = "The Better Backpack is made from 100% recycled plastic but looks and feels like canvas. We were sent the grey bag with the tan leather accents and silver zippers. I’ve personally always liked tan leather paired with the color grey and appreciate the feel of the leather pull tabs and handles at the top of the bag. Additionally the inside is navy blue with a diagonal stitch pattern which gives it an air of sophistication."
                        }

                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Climbing Kit",
                    Description = "Anything you need to climb the mount Everest.",
                    Price = 299.5m,
                    Rating = 5,
                    Type = ProductTypeEnum.ClimbingGear,
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
                    Type = ProductTypeEnum.Kayaks,
                    Stock = 8,
                    PhotoFileName = "shutterstock_441989509.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "So this is my 1st ever...",
                            Review = "So this is my 1st ever kayak and my 1st experience paddling a kayak. I struggled with whether I should spend more money to buy a \"Fishing\" kayak, or even a \"higher end\" kayak because my fear was paddling around a bathtub on the lake. I have to say, I love this kayak for me. It doesn\'t have a lot of the bells and whistles that some of the pricier kayaks have but, I\'m not disappointed.\r\n\r\nIt\'s pretty bare bones aside from some dry storage areas and some bungees. It does have a bungee to hold your paddle on the side. I feel it paddles very easy. It goes exactly where I want it to, I didn\'t struggle to keep it on course. A stiff wind can knock you off track but it was very sturdy and I feel like it would take a lot to tip it over. I stayed fairly dry aside from the dripping off the paddle but its a sit on top so thats to be expected."
                        },
                        new ProductReview
                        {
                            Title = "Great for all genders",
                            Review = "I am a fit 5'7 woman 140lbs and I take my 30# dog along with no troubles. I have fished with it by using a bucket strapped in the back with my bungee cords. It holds my rods and small tackle tray, bug spray etc so I can get to it all easily. I can even get it up on the roof of my jeep alone. "
                        },
                        new ProductReview
                        {
                            Title = "Happy",
                            Review = "Very happy with my purchase and I recommend this to anyone who doesn't want to spend over 600$ on a kayak but also doesn't want a cheap ole hunk of plastic. "
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Orange Demon",
                    Description = "One person kayak with hyper boost button.",
                    Price = 450m,
                    Rating = 2,
                    Type = ProductTypeEnum.Kayaks,
                    Stock = 1,
                    PhotoFileName = "shutterstock_495259978.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview {
                        Title = "Hobie took the paddle out",
                            Review = "Hobie took the paddle out of the hands of the masses, and changed kayak fishing forever. Ive heavily fished the \'Revo\' since 2011 and feel its about perfect for my use. As a serious cyclist its a natural fit, and it can cover huge distances. The torque the Mirage drive generates in rough conditions is often overlooked. I feel it could easily pull any propeller driven kayak backwards in a tug-o-war. I recently weighed my bare hull at 69#s, and that\'s not too shabby for ANY pedal yak. I still fish from paddle yaks, but I spend more time with the rods in my hands when on the Revo."
                            }
                    }
                });

                dbContext.SaveChanges();
            }
        }
    }
}
