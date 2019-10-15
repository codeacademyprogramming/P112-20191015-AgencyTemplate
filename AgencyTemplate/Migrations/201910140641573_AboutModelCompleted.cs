namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AboutModelCompleted : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Title", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Abouts", "Description", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Abouts", "StartDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Abouts", "EndDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Abouts", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Abouts", "Description", c => c.String());
            AlterColumn("dbo.Abouts", "Title", c => c.String(nullable: false));
        }
    }
}
