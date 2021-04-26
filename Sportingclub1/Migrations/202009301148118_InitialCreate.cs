namespace Sportingclub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.trainees",
                c => new
                    {
                        ID = c.Int(nullable: true, identity: true),
                        name = c.String(),
                        gender = c.String(),
                        age = c.Int(nullable: false),
                        Email = c.String(),
                        sport_ID = c.String(maxLength: 128),
                        trainer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sports", t => t.sport_ID)
                .ForeignKey("dbo.Trainers", t => t.trainer_ID)
                .Index(t => t.sport_ID)
                .Index(t => t.trainer_ID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        gender = c.String(),
                        salary = c.Double(nullable: false),
                        age = c.Int(nullable: false),
                        Email = c.String(),
                        sport_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sports", t => t.sport_ID)
                .Index(t => t.sport_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.trainees", "trainer_ID", "dbo.Trainers");
            DropForeignKey("dbo.Trainers", "sport_ID", "dbo.Sports");
            DropForeignKey("dbo.trainees", "sport_ID", "dbo.Sports");
            DropIndex("dbo.Trainers", new[] { "sport_ID" });
            DropIndex("dbo.trainees", new[] { "trainer_ID" });
            DropIndex("dbo.trainees", new[] { "sport_ID" });
            DropTable("dbo.Trainers");
            DropTable("dbo.trainees");
            DropTable("dbo.Sports");
        }
    }
}
