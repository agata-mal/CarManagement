namespace repo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodaniePolaDateNaCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Date");
        }
    }
}
