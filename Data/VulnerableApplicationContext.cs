using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VulnerableApplication.Models;

namespace VulnerableApplication.Models
{
    public class VulnerableApplicationContext : DbContext
    {
        public VulnerableApplicationContext (DbContextOptions<VulnerableApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<VulnerableApplication.Models.Movie> Movie { get; set; }
    }
}
