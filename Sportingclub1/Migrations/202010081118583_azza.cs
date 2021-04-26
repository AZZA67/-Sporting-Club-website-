namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class azza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.trainees", "Training_Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.trainees", "Training_Date");
        }
    }
}
