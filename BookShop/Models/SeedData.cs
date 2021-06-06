using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class SeedData
    {
        //if there is no data in db, it checks if the app works with an example data.
        public static void Seed(IApplicationBuilder app)
        {
            BookContext context = app.ApplicationServices.GetRequiredService<BookContext>();
            context.Database.Migrate();

            if (!context.Books.Any())
            {
                context.Books.Add(
                    new Book
                    {
                        Titel = "Anna Karenina",
                        Erscheinungsdatum = DateTime.Today,
                        Autor = "Leo Tolstoy",
                        Page = 864,
                        Language = "Russian",
                        Stock = 3
                    });
            }
            context.SaveChanges();
        }

    }
}
