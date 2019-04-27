namespace Restaurante.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeraversion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_CAMAREROS",
                c => new
                    {
                        COD_CAMARERO = c.Int(nullable: false, identity: true),
                        NOM_CAMARERO = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.COD_CAMARERO);
            
            CreateTable(
                "dbo.TBL_CLIENTES",
                c => new
                    {
                        COD_CLIENTE = c.Int(nullable: false, identity: true),
                        NOM_CLIENTE = c.String(nullable: false, maxLength: 100),
                        OBS_CLIENTE = c.String(nullable: false),
                        FEC_REGISTRO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.COD_CLIENTE);
            
            CreateTable(
                "dbo.TBL_DETALLEFACTURA",
                c => new
                    {
                        COD_DETALLEF = c.Int(nullable: false, identity: true),
                        COD_FACTURA = c.Int(nullable: false),
                        PLATO = c.String(nullable: false),
                        IMPORTE = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.COD_DETALLEF)
                .ForeignKey("dbo.TBL_FACTURA", t => t.COD_FACTURA, cascadeDelete: true)
                .Index(t => t.COD_FACTURA);
            
            CreateTable(
                "dbo.TBL_FACTURA",
                c => new
                    {
                        COD_FACTURA = c.Int(nullable: false, identity: true),
                        COD_CLIENTE = c.Int(nullable: false),
                        COD_CAMARERO = c.Int(nullable: false),
                        COD_MESA = c.Int(nullable: false),
                        FEC_FACTURA = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.COD_FACTURA)
                .ForeignKey("dbo.TBL_CAMAREROS", t => t.COD_CAMARERO, cascadeDelete: true)
                .ForeignKey("dbo.TBL_CLIENTES", t => t.COD_CLIENTE, cascadeDelete: true)
                .ForeignKey("dbo.TBL_MESAS", t => t.COD_MESA, cascadeDelete: true)
                .Index(t => t.COD_CAMARERO)
                .Index(t => t.COD_CLIENTE)
                .Index(t => t.COD_MESA);
            
            CreateTable(
                "dbo.TBL_MESAS",
                c => new
                    {
                        COD_MESA = c.Int(nullable: false, identity: true),
                        UBICA_MESA = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.COD_MESA);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_DETALLEFACTURA", "COD_FACTURA", "dbo.TBL_FACTURA");
            DropForeignKey("dbo.TBL_FACTURA", "COD_MESA", "dbo.TBL_MESAS");
            DropForeignKey("dbo.TBL_FACTURA", "COD_CLIENTE", "dbo.TBL_CLIENTES");
            DropForeignKey("dbo.TBL_FACTURA", "COD_CAMARERO", "dbo.TBL_CAMAREROS");
            DropIndex("dbo.TBL_DETALLEFACTURA", new[] { "COD_FACTURA" });
            DropIndex("dbo.TBL_FACTURA", new[] { "COD_MESA" });
            DropIndex("dbo.TBL_FACTURA", new[] { "COD_CLIENTE" });
            DropIndex("dbo.TBL_FACTURA", new[] { "COD_CAMARERO" });
            DropTable("dbo.TBL_MESAS");
            DropTable("dbo.TBL_FACTURA");
            DropTable("dbo.TBL_DETALLEFACTURA");
            DropTable("dbo.TBL_CLIENTES");
            DropTable("dbo.TBL_CAMAREROS");
        }
    }
}
