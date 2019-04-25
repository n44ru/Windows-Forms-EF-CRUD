namespace Ares1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ZonaAlarmas", "TipoProcedimientoId", "dbo.TipoProcedimientoes");
            DropIndex("dbo.ZonaAlarmas", new[] { "TipoProcedimientoId" });
            RenameColumn(table: "dbo.ZonaAlarmas", name: "TipoProcedimientoId", newName: "TipoProcedimiento_TipoProcedimientoId");
            AlterColumn("dbo.ZonaAlarmas", "TipoProcedimiento_TipoProcedimientoId", c => c.Int());
            CreateIndex("dbo.ZonaAlarmas", "TipoProcedimiento_TipoProcedimientoId");
            AddForeignKey("dbo.ZonaAlarmas", "TipoProcedimiento_TipoProcedimientoId", "dbo.TipoProcedimientoes", "TipoProcedimientoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZonaAlarmas", "TipoProcedimiento_TipoProcedimientoId", "dbo.TipoProcedimientoes");
            DropIndex("dbo.ZonaAlarmas", new[] { "TipoProcedimiento_TipoProcedimientoId" });
            AlterColumn("dbo.ZonaAlarmas", "TipoProcedimiento_TipoProcedimientoId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ZonaAlarmas", name: "TipoProcedimiento_TipoProcedimientoId", newName: "TipoProcedimientoId");
            CreateIndex("dbo.ZonaAlarmas", "TipoProcedimientoId");
            AddForeignKey("dbo.ZonaAlarmas", "TipoProcedimientoId", "dbo.TipoProcedimientoes", "TipoProcedimientoId", cascadeDelete: true);
        }
    }
}
