namespace Portal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SegmentInitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Segments",
                c => new
                    {
                        SatoriId = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SatoriId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Segments");
        }
    }
}
