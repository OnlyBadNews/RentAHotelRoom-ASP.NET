using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentAHotelRoom.Models;

namespace RentAHotelRoom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RentAHotelRoom.Models.Hotel> Hotel { get; set; }
        public DbSet<RentAHotelRoom.Models.HotelRoom> HotelRoom { get; set; }
    }
}
