namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.trainees", "SportName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.trainees", "SportName", c => c.String(nullable: false));
        }
    }
}
