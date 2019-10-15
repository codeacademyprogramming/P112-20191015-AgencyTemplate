namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountLevelAddded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Level", c => c.Int(nullable: false));
            AddColumn("dbo.Accounts", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Status");
            DropColumn("dbo.Accounts", "Level");
        }
    }
}
