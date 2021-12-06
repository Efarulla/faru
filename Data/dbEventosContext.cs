using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlantillaAppi.Models;

namespace PlantillaAppi.Data
{
    public class dbEventosContext : DbContext
    {
        public dbEventosContext (DbContextOptions<dbEventosContext> options)
            : base(options)
        {
        }

        public DbSet<PlantillaAppi.Models.Eventos> Eventos { get; set; }
    }
}
