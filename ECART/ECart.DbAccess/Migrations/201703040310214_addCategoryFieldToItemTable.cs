namespace ECart.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoryFieldToItemTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "Category");
        }
    }
}
