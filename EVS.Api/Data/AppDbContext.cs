﻿using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Datas
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        DbSet<User> Users { get; set; }
        DbSet<Feedback> Feedbacks { get; set; }
        DbSet<Ride> Rides { get; set; }
        DbSet<Reservation> Reservations { get; set; }

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
        }
    }
}
