using EVS.Api.Data.Seeds;
using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Feedbacks)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reservations)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.Restrict);

            List<User> users = UserSeed.Seed(modelBuilder);

            List<Ride> rides = RideSeed.Seed(modelBuilder, users);

            List<Reservation> reservations = ReservationSeed.Seed(modelBuilder, users, rides);

            List<Feedback> feedbacks = FeedbackSeed.Seed(modelBuilder, users, rides);
        }
    }
}
