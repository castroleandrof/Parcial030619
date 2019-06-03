using WebApplication2.Models;
namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Data.PiezasYProvDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Data.PiezasYProvDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Pieza.AddOrUpdate(x => x.Id,
               new Piezas() { Id = 1, nombre = "tornillo" },
               new Piezas() { Id = 2, nombre = "tuerca" },
               new Piezas() { Id = 3, nombre = "arandela" });

            context.Proveedor.AddOrUpdate(x => x.Id,
                new Proveedores() { Id = 1, nombre = "Jose" },
                new Proveedores() { Id = 2, nombre = "Pedro" },
                new Proveedores() { Id = 3, nombre = "Cristian" });

            context.Suministra.AddOrUpdate(x => x.codigoPieza,
                new Suministra() { codigoPieza = 1, idProveedor = 2, precio = 100 },
                new Suministra() { codigoPieza = 2, idProveedor = 3, precio = 50 },
                new Suministra() { codigoPieza = 3, idProveedor = 1, precio = 200 });

        }
    }
}
