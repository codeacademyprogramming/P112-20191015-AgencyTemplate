namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AboutTitleModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "Title", c => c.String());
        }
    }
}
