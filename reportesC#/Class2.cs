using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace reportesC_
{

    public class AppDbContext : DbContext
    {
       
        public AppDbContext() : base("name=MiConexion") { }

        
        public DbSet<Producto> Productos { get; set; }
    }
}
