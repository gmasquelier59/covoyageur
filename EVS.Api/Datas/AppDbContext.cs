using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Datas
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        DbSet<User> Users { get; set; }
        DbSet<Feedback> Feedbacks { get; set; }
        DbSet<Ride> Rides { get; set; }
        DbSet<Reservation> Reservations { get; set; }
    }
}
