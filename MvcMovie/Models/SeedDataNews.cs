using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.News;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcNewsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcNewsContext>>()))
            {
                // Look for any movies.
                if (context.News.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new News
                    {
                        ID = "1",
                        Name = "When Harry Met Sally",
                    };


                );
                context.SaveChanges();
            }
        }
    }
}