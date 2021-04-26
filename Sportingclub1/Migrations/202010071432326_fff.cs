namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.trainees", "Sport_Name", c => c.Int(nullable: false));
            DropColumn("dbo.trainees", "SportName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.trainees", "SportName", c => c.String(nullable: false));
            DropColumn("dbo.trainees", "Sport_Name");
        }
    }
}
