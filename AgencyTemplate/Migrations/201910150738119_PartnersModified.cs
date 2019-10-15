namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartnersModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Partners", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Partners", "Photo", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Partners", "Photo", c => c.String());
            AlterColumn("dbo.Partners", "Name", c => c.String());
        }
    }
}
