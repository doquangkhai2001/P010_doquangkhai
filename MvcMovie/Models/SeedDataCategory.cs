using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Category;
using System;
using System.Linq;

namespace MvcMovie.Category
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCategory(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCategory>>()))
            {
                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                        ID = "1",
                        Name = "When Harry Met Sally",
                        
                    }


                );
                context.SaveChanges();
            }
        }
    }
}