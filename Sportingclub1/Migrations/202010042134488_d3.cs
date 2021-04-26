namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Email", c => c.String());
            AddColumn("dbo.trainees", "Password", c => c.String(nullable: true));
            AddColumn("dbo.trainees", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.trainees", "name", c => c.String(nullable: true));
            AlterColumn("dbo.trainees", "gender", c => c.String(nullable: true));
            AlterColumn("dbo.trainees", "Email", c => c.String(nullable: true));
            AlterColumn("dbo.trainees", "SportName", c => c.String(nullable: true));
            DropColumn("dbo.Accounts", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "UserName", c => c.String());
            AlterColumn("dbo.trainees", "SportName", c => c.String());
            AlterColumn("dbo.trainees", "Email", c => c.String());
            AlterColumn("dbo.trainees", "gender", c => c.String());
            AlterColumn("dbo.trainees", "name", c => c.String());
            DropColumn("dbo.trainees", "ConfirmPassword");
            DropColumn("dbo.trainees", "Password");
            DropColumn("dbo.Accounts", "Email");
        }
    }
}
