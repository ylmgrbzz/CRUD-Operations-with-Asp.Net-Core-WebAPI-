using HotelFinderEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2Q3K5QO\SQLEXPRESS;Database=HotelDb;Trusted_Connection=true");
        }
        public DbSet<Hotel> Hotels { get; set; }
    }

}


