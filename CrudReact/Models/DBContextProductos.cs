using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudReact.Models
{
    public class DBContextProductos:DbContext
    {
        public DBContextProductos(DbContextOptions<DBContextProductos> options):base(options)
        {

        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Almacenes> Almacenes { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }
    }
}
