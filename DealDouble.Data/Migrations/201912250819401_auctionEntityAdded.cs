﻿namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auctionEntityAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        AuctionID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PictureURL = c.String(),
                        Discription = c.String(),
                        ActualAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartingTime = c.DateTime(nullable: false),
                        EndingTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuctionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Auctions");
        }
    }
}
