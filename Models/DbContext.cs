using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace erik_tech.Models
{
    public class DbContextApp : DbContext
    {
        public DbContextApp (DbContextOptions<DbContextApp> options)
            : base(options)
        {
        }

        public DbSet<erik_tech.Models.Cuenta> cuenta { get; set; }
        public DbSet<erik_tech.Models.Articulo> articulo {get;set;}
        
    }
}