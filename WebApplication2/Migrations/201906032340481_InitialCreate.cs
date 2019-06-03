namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Piezas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suministras",
                c => new
                    {
                        idProveedor = c.Int(nullable: false),
                        codigoPieza = c.Int(nullable: false),
                        precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idProveedor, t.codigoPieza });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suministras");
            DropTable("dbo.Proveedores");
            DropTable("dbo.Piezas");
        }
    }
}
