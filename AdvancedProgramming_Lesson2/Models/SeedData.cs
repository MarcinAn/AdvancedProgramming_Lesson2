﻿using AdvancedProgramming_Lesson2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AdvancedProgramming_Lesson2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcContext>>());
            // Look for any movies.
            if (context.Movie.Any())
            {
                return; // DB has been seeded
            }
            context.Movie.AddRange(
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Rating="",
                Description=""
            },
            new Movie
            {
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Price = 8.99M,
                Rating = "",
                Description = ""
            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "",
                Description = ""
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Price = 3.99M,
                Rating = "",
                Description = ""
            }
            );
            context.SaveChanges();
        }
    }
}
