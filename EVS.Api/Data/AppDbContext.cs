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

            Guid adminGuid = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = adminGuid,
                    IsAdmin = true,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Pseudo = "admin",
                    Birthday = DateTime.Now,
                    CarDescription = "",
                    PhoneNumber = "0102030405",
                    Email = "admin@envoituresimone.com",
                    Password = "123456789" // TODO : Faire le hash du password une fois JWT en place
                }
            );
        }
    }
}
