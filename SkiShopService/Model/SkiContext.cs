using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SkiShopService.Model
{
    public class SkiContext : DbContext
    {
        public SkiContext(DbContextOptions<SkiContext> options) : base(options)
        {

        }

        public DbSet<Ski> InMemorySkis { get; set; }

    }
}
