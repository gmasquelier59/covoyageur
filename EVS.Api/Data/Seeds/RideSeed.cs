using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Data.Seeds
{
    public class RideSeed
    {
        public static List<Ride> Seed(ModelBuilder modelBuilder, List<User> users)
        {
            double lilleLatitude = 50.6310733;
            double lilleLongitude = 3.0056983;

            double parisLatitude = 48.8588255;
            double parisLongitude = 2.2646344;

            double marseilleLatitude = 43.280227;
            double marseilleLongitude = 5.2158397;

            double lyonLatitude = 45.757814;
            double lyonLongitude = 4.832011;

            double bordeauxLatitude = 44.841225;
            double bordeauxLongitude = -0.580036;

            int distanceLilleParis = 204;
            int distanceLilleMarseille = 834;
            int distanceParisMarseille = 660;
            int distanceLyonBordeaux = 435;
            int distanceLilleBordeaux = 699;

            List<Ride> rides = new()
            {
                //  Lille -> Paris
                new Ride()
                {
                    Id = Guid.NewGuid(),
                    UserId = users[1].Id,
                    StartCity = "Lille",
                    StartLatitude = lilleLatitude,
                    StartLongitude = lilleLongitude,
                    EndCity = "Paris",
                    EndLatitude = parisLatitude,
                    EndLongitude = parisLongitude,
                    Departure = DateTime.Today.AddDays(5).AddHours(7),
                    Seats = 3,
                    Price = 20,
                    Distance = distanceLilleParis
                },
                // Lille -> Paris
                new Ride()
                {
                    Id = Guid.NewGuid(),
                    UserId = users[3].Id,
                    StartCity = "Lille",
                    StartLatitude = lilleLatitude,
                    StartLongitude = lilleLongitude,
                    EndCity = "Paris",
                    EndLatitude = parisLatitude,
                    EndLongitude = parisLongitude,
                    Departure = DateTime.Today.AddDays(6).AddHours(11),
                    Seats = 2,
                    Price = 18,
                    Distance = distanceLilleParis
                },
                // Paris -> Lille
                new Ride()
                {
                    Id = Guid.NewGuid(),
                    UserId = users[2].Id,
                    StartCity = "Paris",
                    StartLatitude = parisLatitude,
                    StartLongitude = parisLongitude,
                    EndCity = "Lille",
                    EndLatitude = lilleLatitude,
                    EndLongitude = lilleLongitude,
                    Departure = DateTime.Today.AddDays(10).AddHours(17),
                    Seats = 4,
                    Price = 23,
                    Distance = distanceLilleParis
                },
                // Paris -> Marseille
                new Ride()
                {
                    Id = Guid.NewGuid(),
                    UserId = users[5].Id,
                    StartCity = "Paris",
                    StartLatitude = parisLatitude,
                    StartLongitude = parisLongitude,
                    EndCity = "Marseille",
                    EndLatitude = marseilleLatitude,
                    EndLongitude = marseilleLongitude,
                    Departure = DateTime.Today.AddDays(17).AddHours(5),
                    Seats = 1,
                    Price = 39,
                    Distance = distanceParisMarseille
                },
                // Lyon -> Bordeaux
                new Ride()
                {
                    Id = Guid.NewGuid(),
                    UserId = users[5].Id,
                    StartCity = "Lyon",
                    StartLatitude = lyonLatitude,
                    StartLongitude = lyonLongitude,
                    EndCity = "Bordeaux",
                    EndLatitude = bordeauxLatitude,
                    EndLongitude = bordeauxLongitude,
                    Departure = DateTime.Today.AddDays(9).AddHours(4),
                    Seats = 3,
                    Price = 46,
                    Distance = distanceLyonBordeaux
                },
                // Bordeaux -> Lille
                new Ride()
                {
                    Id = Guid.NewGuid(),
                    UserId = users[5].Id,
                    StartCity = "Bordeaux",
                    StartLatitude = bordeauxLatitude,
                    StartLongitude = bordeauxLongitude,
                    EndCity = "Lille",
                    EndLatitude = lilleLatitude,
                    EndLongitude = lilleLatitude,
                    Departure = DateTime.Today.AddDays(-4).AddHours(8),
                    Seats = 2,
                    Price = 52,
                    Distance = distanceLilleBordeaux
                }
            };

            foreach (Ride ride in rides)
                modelBuilder.Entity<Ride>().HasData(ride);

            return rides;
        }
    }
}