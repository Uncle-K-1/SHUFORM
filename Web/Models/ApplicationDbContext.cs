using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    
    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
           Database.EnsureCreated();

               }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Participant> Participants { get; set; }
            public DbSet<Booking> Bookings { get; set; }
        }
    
}
