using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Data.Seeds
{
    public class UserSeed
    {
        public static List<User> Seed(ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    Id = Guid.NewGuid(),
                    IsAdmin = true,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Pseudo = "admin",
                    Birthday = DateTime.Now,
                    CarDescription = "",
                    PhoneNumber = "0102030405",
                    Photo = "https://thispersondoesnotexist.com/",
                    Email = "admin@envoituresimone.com",
                    Password = "admin" // TODO
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    IsAdmin = false,
                    FirstName = "Amye",
                    LastName = "Colchett",
                    Pseudo = "acolchett0",
                    Birthday = DateTime.Parse("03/12/1998"),
                    CarDescription = "Daewoo",
                    PhoneNumber = "0337862430",
                    Photo = "https://thispersondoesnotexist.com/",
                    Email = "naldren0@webeden.co.uk",
                    Password = @"aB0.oB?iBy\" // TODO
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    IsAdmin = false,
                    FirstName = "Nap",
                    LastName = "Droogan",
                    Pseudo = "ddroogan1",
                    Birthday = DateTime.Parse("30/08/1974"),
                    CarDescription = "Lexus",
                    PhoneNumber = "0322458382",
                    Photo = "https://thispersondoesnotexist.com/",
                    Email = "ddroogan1@thetimes.co.uk",
                    Password = @"tH0)I/Mt<xZwz2" // TODO
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    IsAdmin = false,
                    FirstName = "Kordula",
                    LastName = "Pedwell",
                    Pseudo = "kpedwell2",
                    Birthday = DateTime.Parse("09/05/1988"),
                    CarDescription = "Jeep",
                    PhoneNumber = "0903434966",
                    Photo = "https://thispersondoesnotexist.com/",
                    Email = "kpedwell2@icq.com",
                    Password = @"pH3+&{WpvdT" // TODO
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    IsAdmin = false,
                    FirstName = "Lindsey",
                    LastName = "Hair",
                    Pseudo = "lhair3",
                    Birthday = DateTime.Parse("05/06/1984"),
                    CarDescription = "Austin",
                    PhoneNumber = "0162842195",
                    Photo = "https://thispersondoesnotexist.com/",
                    Email = "lhair3@wikipedia.org",
                    Password = @"eE0'6STA~9O#Suj{" // TODO
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    IsAdmin = false,
                    FirstName = "Carlota",
                    LastName = "Grigorkin",
                    Pseudo = "cgrigorkin4",
                    Birthday = DateTime.Parse("24/08/1997"),
                    CarDescription = "BMW",
                    PhoneNumber = "0494223557",
                    Photo = "https://thispersondoesnotexist.com/",
                    Email = "cgrigorkin4@theatlantic.com",
                    Password = @"tZ9\4s(DQvnvE" // TODO
                }
            };

            foreach (User user in users)
                modelBuilder.Entity<User>().HasData(user);

            return users;
        }
    }
}
