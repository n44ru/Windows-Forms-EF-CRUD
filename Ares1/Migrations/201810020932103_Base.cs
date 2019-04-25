namespace Ares1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Camaras",
                c => new
                    {
                        CamaraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IP = c.String(),
                        Puerto = c.String(),
                        Usuario = c.String(),
                        Pass = c.String(),
                        Url_Rstp = c.String(),
                        TCamara = c.Int(nullable: false),
                        ZonaAlarmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CamaraId)
                .ForeignKey("dbo.ZonaAlarmas", t => t.ZonaAlarmaId, cascadeDelete: true)
                .Index(t => t.ZonaAlarmaId);
            
            CreateTable(
                "dbo.ZonaAlarmas",
                c => new
                    {
                        ZonaAlarmaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        CentralId = c.Int(nullable: false),
                        TipoProcedimientoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZonaAlarmaId)
                .ForeignKey("dbo.Centrals", t => t.CentralId, cascadeDelete: true)
                .ForeignKey("dbo.TipoProcedimientoes", t => t.TipoProcedimientoId, cascadeDelete: true)
                .Index(t => t.CentralId)
                .Index(t => t.TipoProcedimientoId);
            
            CreateTable(
                "dbo.Centrals",
                c => new
                    {
                        CentralId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IP = c.String(),
                        Puerto = c.String(),
                        PassPhrase = c.String(),
                        AccessCode = c.String(),
                        Descripción = c.String(),
                    })
                .PrimaryKey(t => t.CentralId);
            
            CreateTable(
                "dbo.TipoProcedimientoes",
                c => new
                    {
                        TipoProcedimientoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoProcedimientoId);
            
            CreateTable(
                "dbo.ListaNegras",
                c => new
                    {
                        ListaNegraId = c.Int(nullable: false, identity: true),
                        Matricula = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Color = c.String(),
                        Observaciones = c.String(),
                    })
                .PrimaryKey(t => t.ListaNegraId);
            
            CreateTable(
                "dbo.RegistroAlarmas",
                c => new
                    {
                        RegistroAlarmaId = c.Int(nullable: false, identity: true),
                        FechaRegistro = c.DateTime(nullable: false),
                        UsuarioAtiende = c.String(),
                        SeguimientoProcedimiento = c.Boolean(nullable: false),
                        FechaSeguimiento = c.DateTime(nullable: false),
                        Resultad = c.Int(nullable: false),
                        Observaciones = c.String(),
                        Vecino = c.String(),
                        TipoProcedimientoId = c.Int(nullable: false),
                        ZonaAlarma_ZonaAlarmaId = c.Int(),
                    })
                .PrimaryKey(t => t.RegistroAlarmaId)
                .ForeignKey("dbo.TipoProcedimientoes", t => t.TipoProcedimientoId, cascadeDelete: true)
                .ForeignKey("dbo.ZonaAlarmas", t => t.ZonaAlarma_ZonaAlarmaId)
                .Index(t => t.TipoProcedimientoId)
                .Index(t => t.ZonaAlarma_ZonaAlarmaId);
            
            CreateTable(
                "dbo.VideoClips",
                c => new
                    {
                        VideoClipId = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        RegistroAlarmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VideoClipId)
                .ForeignKey("dbo.RegistroAlarmas", t => t.RegistroAlarmaId, cascadeDelete: true)
                .Index(t => t.RegistroAlarmaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroAlarmas", "ZonaAlarma_ZonaAlarmaId", "dbo.ZonaAlarmas");
            DropForeignKey("dbo.VideoClips", "RegistroAlarmaId", "dbo.RegistroAlarmas");
            DropForeignKey("dbo.RegistroAlarmas", "TipoProcedimientoId", "dbo.TipoProcedimientoes");
            DropForeignKey("dbo.ZonaAlarmas", "TipoProcedimientoId", "dbo.TipoProcedimientoes");
            DropForeignKey("dbo.ZonaAlarmas", "CentralId", "dbo.Centrals");
            DropForeignKey("dbo.Camaras", "ZonaAlarmaId", "dbo.ZonaAlarmas");
            DropIndex("dbo.VideoClips", new[] { "RegistroAlarmaId" });
            DropIndex("dbo.RegistroAlarmas", new[] { "ZonaAlarma_ZonaAlarmaId" });
            DropIndex("dbo.RegistroAlarmas", new[] { "TipoProcedimientoId" });
            DropIndex("dbo.ZonaAlarmas", new[] { "TipoProcedimientoId" });
            DropIndex("dbo.ZonaAlarmas", new[] { "CentralId" });
            DropIndex("dbo.Camaras", new[] { "ZonaAlarmaId" });
            DropTable("dbo.VideoClips");
            DropTable("dbo.RegistroAlarmas");
            DropTable("dbo.ListaNegras");
            DropTable("dbo.TipoProcedimientoes");
            DropTable("dbo.Centrals");
            DropTable("dbo.ZonaAlarmas");
            DropTable("dbo.Camaras");
        }
    }
}
