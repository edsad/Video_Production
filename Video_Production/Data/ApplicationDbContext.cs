using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Video_Production.Models;

namespace Video_Production.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Video_Production.Models.Client> Client { get; set; }

        public DbSet<Video_Production.Models.Production> Production { get; set; }

        public DbSet<Video_Production.Models.ProductionType> ProductionType { get; set; }

        public DbSet<Video_Production.Models.Users> Users { get; set; }

        public DbSet<Video_Production.Models.Crew> Crew { get; set; }
    }
}
