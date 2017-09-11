using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Video_Production.Models;

namespace Video_Production.Models
{
    public class Video_ProductionContext : DbContext
    {
        public Video_ProductionContext (DbContextOptions<Video_ProductionContext> options)
            : base(options)
        {
        }

        public DbSet<Video_Production.Models.Client> Client { get; set; }

        public DbSet<Video_Production.Models.Production> Production { get; set; }

        public DbSet<Video_Production.Models.ProductionType> ProductionType { get; set; }

        public DbSet<Video_Production.Models.Users> Users { get; set; }
    }
}
