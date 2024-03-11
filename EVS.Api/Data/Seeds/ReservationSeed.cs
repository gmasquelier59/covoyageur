using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Data.Seeds
{
    public class ReservationSeed
    {
        public static List<Reservation> Seed(ModelBuilder modelBuilder, List<User> users, List<Ride> rides)
        {
            List<Reservation> reservations = new()
            {
                new Reservation()
                {
                    Id = Guid.NewGuid(),
                    RideId = rides[1].Id,
                    UserId = users[4].Id,
                    Status = Core.Enums.ReservationStatus.Confirmed,
                    ReservationDate = DateTime.Today.AddDays(-1)
                },
                new Reservation()
                {
                    Id = Guid.NewGuid(),
                    RideId = rides[2].Id,
                    UserId = users[5].Id,
                    Status = Core.Enums.ReservationStatus.Refused,
                    ReservationDate = DateTime.Today.AddDays(-2)
                },
                new Reservation()
                {
                    Id = Guid.NewGuid(),
                    RideId = rides[1].Id,
                    UserId = users[3].Id,
                    Status = Core.Enums.ReservationStatus.Confirmed,
                    ReservationDate = DateTime.Today.AddDays(-3)
                }
            };

            foreach (Reservation reservation in reservations)
                modelBuilder.Entity<Reservation>().HasData(reservation);

            return reservations;
        }
    }
}