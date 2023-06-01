namespace BusinessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolSqlMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        Days = c.Int(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Restaurant_RestaurantId = c.Int(),
                        Client_ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .Index(t => t.Restaurant_RestaurantId)
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        YearlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Client_ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.RestaurantId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .Index(t => t.Client_ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "Restaurant_RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurants", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Restaurants", new[] { "Client_ClientId" });
            DropIndex("dbo.Reservations", new[] { "Client_ClientId" });
            DropIndex("dbo.Reservations", new[] { "Restaurant_RestaurantId" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Reservations");
            DropTable("dbo.Clients");
        }
    }
}
