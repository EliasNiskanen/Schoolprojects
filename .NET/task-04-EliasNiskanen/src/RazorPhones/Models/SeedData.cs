using Microsoft.EntityFrameworkCore;
using RazorPhones.Data;

namespace RazorPhones.Models;

    public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PhonesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<PhonesContext>>()))
        {
            if (context == null || context.Phones == null)
            {
                throw new ArgumentNullException("Null PhonesContext");
            }

            context.Database.EnsureCreated();

            // Look for any phones.
            if (context.Phones.Any())
            {
                return;   // DB has been seeded
            }

            context.Phones.AddRange(
                new Phone {
                    Id = 1,
                    Make = "Apple",
                    Model = "iPhone 13",
                    PublishDate = new DateTime(2021, 9, 11),
                    RAM = 6 * 1024,
                    Created = new DateTime(2021, 9, 11),
                    Modified = new DateTime(2021, 9, 11)
                },

                new Phone {
                    Id = 2,
                    Make = "Apple",
                    Model = "iPhone 13 Max",
                    PublishDate = new DateTime(2021, 9, 11),
                    RAM = 8 * 1024,
                    Created = new DateTime(2021, 9, 11),
                    Modified = new DateTime(2021, 9, 11)
                },

                new Phone {
                    Id = 3,
                    Make = "Nokia",
                    Model = "8",
                    PublishDate = new DateTime(2019, 4, 10),
                    RAM = 4 * 1024,
                    Created = new DateTime(2019, 4, 10),
                    Modified = new DateTime(2019, 4, 10)
                },

                new Phone {
                    Id = 4,
                    Make = "Samsung",
                    Model = "Galaxy S22",
                    PublishDate = new DateTime(2022, 2, 10),
                    RAM = 8 * 1024,
                    Created = new DateTime(2022, 2, 10),
                    Modified = new DateTime(2022, 2, 10)
                },

                new Phone {
                    Id = 5,
                    Make = "Motorola",
                    Model = "X",
                    PublishDate = new DateTime(2020, 8, 23),
                    RAM = 3 * 1024,
                    Created = new DateTime(2020, 8, 23),
                    Modified = new DateTime(2020, 8, 23)
                }
            );
            context.SaveChanges();
        }
    }
}
