namespace Ares1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RegistroAlarmas", "TipoProcedimientoId", "dbo.TipoProcedimientoes");
            DropIndex("dbo.RegistroAlarmas", new[] { "TipoProcedimientoId" });
            RenameColumn(table: "dbo.RegistroAlarmas", name: "TipoProcedimientoId", newName: "TipoProcedimiento_TipoProcedimientoId");
            AlterColumn("dbo.RegistroAlarmas", "TipoProcedimiento_TipoProcedimientoId", c => c.Int());
            CreateIndex("dbo.RegistroAlarmas", "TipoProcedimiento_TipoProcedimientoId");
            AddForeignKey("dbo.RegistroAlarmas", "TipoProcedimiento_TipoProcedimientoId", "dbo.TipoProcedimientoes", "TipoProcedimientoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroAlarmas", "TipoProcedimiento_TipoProcedimientoId", "dbo.TipoProcedimientoes");
            DropIndex("dbo.RegistroAlarmas", new[] { "TipoProcedimiento_TipoProcedimientoId" });
            AlterColumn("dbo.RegistroAlarmas", "TipoProcedimiento_TipoProcedimientoId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.RegistroAlarmas", name: "TipoProcedimiento_TipoProcedimientoId", newName: "TipoProcedimientoId");
            CreateIndex("dbo.RegistroAlarmas", "TipoProcedimientoId");
            AddForeignKey("dbo.RegistroAlarmas", "TipoProcedimientoId", "dbo.TipoProcedimientoes", "TipoProcedimientoId", cascadeDelete: true);
        }
    }
}
