namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutEndDateModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "EndDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "EndDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
