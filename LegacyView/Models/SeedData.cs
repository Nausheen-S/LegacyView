using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // DI is used to register EF core
using LegacyView.Data; // referencing our DB

namespace LegacyView.Models
{
    public static class SeedData // making the class static
    {
        //seeding the data
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LegacyViewContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LegacyViewContext>>()))
            {
                // Look for any movies.
                if (context.DVD.Any())
                {
                    return;   // DB already has data
                }

                //adding around 10 DVDs
                context.DVD.AddRange(
                    new DVD
                    {
                        DVDName = "Star Trek: Discovery",
                        DVDGenre = "Sci-Fi",
                        DVDDescription = "Discovery series from Star Trek Franchise",
                        DVDPrice = 35.99M,
                        ReleaseDate = DateTime.Parse("2022-12-06"),
                        DVDCustomerReview = 3.0M
                    },
                    new DVD
                    {
                        DVDName = "Star Trek: Picard",
                        DVDGenre = "Sci-Fi",
                        DVDDescription = "Picard series from Star Trek Franchise",
                        DVDPrice = 24.99M,
                        ReleaseDate = DateTime.Parse("2022-10-04"),
                        DVDCustomerReview = 3.5M
                    },
                    new DVD
                    {
                        DVDName = "Beast",
                        DVDGenre = "Thriller",
                        DVDDescription = "A father and his two teenage daughters find themselves hunted by a massive rogue lion intent on proving that the Savannah has but one apex predator.",
                        DVDPrice = 17.95M,
                        ReleaseDate = DateTime.Parse("2022-10-11"),
                        DVDCustomerReview = 3.0M
                    },
                    new DVD
                    {
                        DVDName = "Paws of Fury",
                        DVDGenre = "Animation",
                        DVDDescription = "The story revolves around a scrappy young dog who fights to save a town from becoming the litter box of a nefarious feline warlord.",
                        DVDPrice = 17.95M,
                        ReleaseDate = DateTime.Parse("2022-10-10"),
                        DVDCustomerReview = 3.0M
                    },
                    new DVD
                    {
                        DVDName = "Knives Out",
                        DVDGenre = "Dark Humor",
                        DVDDescription = "A detective investigates the death of a patriarch of an eccentric, combative family.",
                        DVDPrice = 5.00M,
                        ReleaseDate = DateTime.Parse("2020-02-25"),
                        DVDCustomerReview = 3.0M
                    },
                    new DVD
                    {
                        DVDName = "Field Of Dreams",
                        DVDGenre = "Drama",
                        DVDDescription = "A farmer builds a baseball field to inspire Chicago Black Sox to play ball again.",
                        DVDPrice = 5.00M,
                        ReleaseDate = DateTime.Parse("2012-01-10"),
                        DVDCustomerReview = 4.0M
                    },
                    new DVD
                    {
                        DVDName = "The Sound of Music",
                        DVDGenre = "Musical",
                        DVDDescription = "A woman leaves a convent to become governess to the seven children of a Naval officer widower.",
                        DVDPrice = 4.40M,
                        ReleaseDate = DateTime.Parse("2015-03-10"),
                        DVDCustomerReview = 4.0M
                    },
                    new DVD
                    {
                        DVDName = "Victory At Sea",
                        DVDGenre = "Documentary",
                        DVDDescription = "A documentary on the various facets of World War II.",
                        DVDPrice = 4.40M,
                        ReleaseDate = DateTime.Parse("2012-09-18"),
                        DVDCustomerReview = 5.0M
                    },
                    new DVD
                    {
                        DVDName = "Dog",
                        DVDGenre = "Comedy",
                        DVDDescription = "An army ranger and his dog embark on a road trip to attend a friend's funeral.",
                        DVDPrice = 12.90M,
                        ReleaseDate = DateTime.Parse("2022-05-10"),
                        DVDCustomerReview = 2.5M
                    },
                    new DVD
                    {
                        DVDName = "The Holiday",
                        DVDGenre = "Romance",
                        DVDDescription = "Two women exchange homes and end up finding love.",
                        DVDPrice = 5.00M,
                        ReleaseDate = DateTime.Parse("2007-03-13"),
                        DVDCustomerReview = 3.5M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
