namespace ECart.DbAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checkout",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        ItemPrice = c.Int(nullable: false),
                        NumberOfUnits = c.Int(nullable: false),
                        BatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CheckoutSummery", t => t.BatchId, cascadeDelete: true)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.BatchId);
            
            CreateTable(
                "dbo.CheckoutSummery",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentMethod = c.Int(nullable: false),
                        CardNumber = c.String(nullable: false),
                        CheckoutDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        UserType = c.Int(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Checkout", "ItemId", "dbo.Item");
            DropForeignKey("dbo.Checkout", "BatchId", "dbo.CheckoutSummery");
            DropForeignKey("dbo.CheckoutSummery", "UserId", "dbo.User");
            DropIndex("dbo.CheckoutSummery", new[] { "UserId" });
            DropIndex("dbo.Checkout", new[] { "BatchId" });
            DropIndex("dbo.Checkout", new[] { "ItemId" });
            DropTable("dbo.Item");
            DropTable("dbo.User");
            DropTable("dbo.CheckoutSummery");
            DropTable("dbo.Checkout");
        }
    }
}
