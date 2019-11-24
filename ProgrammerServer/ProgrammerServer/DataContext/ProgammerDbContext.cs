using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgrammerServer.Entity;

namespace ProgrammerServer.DataContext
{
    public class ProgammerDbContext : DbContext
    {
        public ProgammerDbContext(DbContextOptions<ProgammerDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Users> Users { get; set; }
    }
}
