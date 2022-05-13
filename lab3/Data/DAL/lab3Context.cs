using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab3.Models;

namespace lab3.Data
{
    public class lab3Context : DbContext
    {
        public lab3Context (DbContextOptions<lab3Context> options)
            : base(options)
        {
        }

        public DbSet<lab3.Models.ParkingSpace>? ParkingSpace { get; set; }
        public DbSet<Pass> Pass { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
