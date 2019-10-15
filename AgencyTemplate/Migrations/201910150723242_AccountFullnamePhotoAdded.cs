namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountFullnamePhotoAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Photo", c => c.String());
            AddColumn("dbo.Accounts", "Fullname", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Fullname");
            DropColumn("dbo.Accounts", "Photo");
        }
    }
}
