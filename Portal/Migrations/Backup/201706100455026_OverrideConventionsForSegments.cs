namespace Portal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForSegments : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Segments", "Type", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Segments", "Type", c => c.String());
        }
    }
}
