namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Judges",
                c => new
                    {
                        JudgeId = c.Int(nullable: false, identity: true),
                        SatoriId = c.String(),
                        Name = c.String(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        ImageUrl = c.String(),
                        CaseHolding = c.String(),
                        AttorneyNames = c.String(),
                        CommonlySitedSources = c.String(),
                        JudicalSystem = c.String(),
                        Jurisdiction = c.String(),
                        NuberOfCases = c.Int(nullable: false),
                        Education = c.String(),
                        Religion = c.String(),
                        Memberships = c.String(),
                    })
                .PrimaryKey(t => t.JudgeId);
            
            CreateTable(
                "dbo.Opinions",
                c => new
                    {
                        OpinionId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 500),
                        Url = c.String(),
                        JudgeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OpinionId)
                .ForeignKey("dbo.Judges", t => t.JudgeId, cascadeDelete: true)
                .Index(t => t.JudgeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Opinions", "JudgeId", "dbo.Judges");
            DropIndex("dbo.Opinions", new[] { "JudgeId" });
            DropTable("dbo.Opinions");
            DropTable("dbo.Judges");
        }
    }
}
