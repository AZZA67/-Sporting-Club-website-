namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.trainees", "SportName", c => c.String());
        }
    }
}
