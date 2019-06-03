using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class PiezasYProvDbContext : DbContext
    {

        public PiezasYProvDbContext():base("PiezasYProvDbContext")
        {
        }

        public DbSet<Piezas> Pieza { get; set; }
        public DbSet<Suministra> Suministra { get; set; }
        public DbSet<Proveedores> Proveedor { get; set; }
    }
}