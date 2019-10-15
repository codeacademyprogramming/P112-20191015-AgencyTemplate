namespace AgencyTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BigPhotoAddedToPortfolio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Portfolios", "BigPhoto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Portfolios", "BigPhoto");
        }
    }
}
