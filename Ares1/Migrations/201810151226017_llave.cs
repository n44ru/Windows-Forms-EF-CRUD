namespace Ares1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class llave : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Camaras", "ZonaAlarmaId", "dbo.ZonaAlarmas");
            DropIndex("dbo.Camaras", new[] { "ZonaAlarmaId" });
            AlterColumn("dbo.Camaras", "ZonaAlarmaId", c => c.Int());
            CreateIndex("dbo.Camaras", "ZonaAlarmaId");
            AddForeignKey("dbo.Camaras", "ZonaAlarmaId", "dbo.ZonaAlarmas", "ZonaAlarmaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Camaras", "ZonaAlarmaId", "dbo.ZonaAlarmas");
            DropIndex("dbo.Camaras", new[] { "ZonaAlarmaId" });
            AlterColumn("dbo.Camaras", "ZonaAlarmaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Camaras", "ZonaAlarmaId");
            AddForeignKey("dbo.Camaras", "ZonaAlarmaId", "dbo.ZonaAlarmas", "ZonaAlarmaId", cascadeDelete: true);
        }
    }
}
