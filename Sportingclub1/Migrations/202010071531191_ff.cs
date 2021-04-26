namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ff : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.trainees", "Sport_Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.trainees", "Sport_Name", c => c.Int(nullable: false));
        }
    }
}
