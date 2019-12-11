namespace repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SSZmianaWCarWorkerIdnaopcjonalny : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "WorkerId", "dbo.Workers");
            DropIndex("dbo.Cars", new[] { "WorkerId" });
            AlterColumn("dbo.Cars", "WorkerId", c => c.Int());
            CreateIndex("dbo.Cars", "WorkerId");
            AddForeignKey("dbo.Cars", "WorkerId", "dbo.Workers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "WorkerId", "dbo.Workers");
            DropIndex("dbo.Cars", new[] { "WorkerId" });
            AlterColumn("dbo.Cars", "WorkerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "WorkerId");
            AddForeignKey("dbo.Cars", "WorkerId", "dbo.Workers", "Id", cascadeDelete: true);
        }
    }
}
