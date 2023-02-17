﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoulSocks.Data;
using System;
using System.Linq;

namespace SoulSocks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SoulSocksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SoulSocksContext>>()))
            {
                // Look for any movies.
                if (context.Sock.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sock.AddRange(


new Sock
{
    Brand = "Nike",
    Material = "Cotton",
    Length = "Full",
Colour = "White",
Price = 9M
},
new Sock
{
    Brand = "Adidas",
    Material = "Nylon",
    Length = "Knee",
Colour = "Black",
Price = 11M
},
new Sock
{
    Brand = "Nike",
    Material = "Nylon",
    Length = "Knee",
    Colour = "Grey",
Price = 19M
},
new Sock
{
    Brand = "Champion",
    Material = "Wool",
    Length = "Ankle",
Colour = "Black",
    Price = 15M
},
new Sock
{
    Brand = "Nike",
    Material = "Cotton",
    Length ="No Show",
Colour = "Black",
    Price = 7M
},


new Sock
{
    Brand = "Adidas",
    Material = "Cotton",
    Length = "Full",
    Colour = "Red",
Price = 12M
},
new Sock
{
    Brand = "Nike",
    Material = "Cotton",
    Length = "No Show",
    Colour = "Black",
    Price = 7M
},
new Sock
{
    Brand = "Gucci",
    Material = "leather",
    Length = "Full",
    Colour = "Red",
    Price = 112M
},
new Sock
{
    Brand = "Champion",
    Material = "Wool",
    Length = "Ankle",
    Colour = "Black",
    Price = 15M
},
new Sock
{
    Brand = "Reebok",
    Material = "Wool",
    Length = "Knee",
    Colour = "purple",
    Price = 15M
}



                );
                context.SaveChanges();
            }
        }
    }
}