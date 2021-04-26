namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d31 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.trainees", "ConfirmPassword", c => c.String(nullable: true));
            AlterColumn("dbo.trainees", "SportName", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.trainees", "SportName", c => c.String());
            AlterColumn("dbo.trainees", "ConfirmPassword", c => c.String());
        }
    }
}
