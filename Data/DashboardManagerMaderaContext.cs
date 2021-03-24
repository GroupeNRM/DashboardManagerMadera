using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DashboardManagerMadera.Models;

namespace DashboardManagerMadera.Data
{
    public class DashboardManagerMaderaContext : DbContext
    {
        public DashboardManagerMaderaContext (DbContextOptions<DashboardManagerMaderaContext> options)
            : base(options)
        {
        }

        public DbSet<DashboardManagerMadera.Models.Commercial> Commercial { get; set; }

        public DbSet<DashboardManagerMadera.Models.Client> Client { get; set; }
    }
}
