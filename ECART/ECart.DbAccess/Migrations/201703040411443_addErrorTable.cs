namespace ECart.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addErrorTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Checkout", newName: "Checkouts");
            RenameTable(name: "dbo.CheckoutSummery", newName: "CheckoutSummerys");
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Item", newName: "Items");
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Exception = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        ErrorStackTrace = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Errors");
            RenameTable(name: "dbo.Items", newName: "Item");
            RenameTable(name: "dbo.Users", newName: "User");
            RenameTable(name: "dbo.CheckoutSummerys", newName: "CheckoutSummery");
            RenameTable(name: "dbo.Checkouts", newName: "Checkout");
        }
    }
}
