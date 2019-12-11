namespace repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieEnumJobPositionNaWorker : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "JobPosition", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "JobPosition", c => c.String());
        }
    }
}
