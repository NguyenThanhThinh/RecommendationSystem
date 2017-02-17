namespace RecommendationSystem.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        item_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.item_Id);
            
            CreateTable(
                "dbo.Pearson_Score",
                c => new
                    {
                        user_Id_1 = c.Int(nullable: false),
                        user_Id_2 = c.Int(nullable: false),
                        Sim_Pearson_Score = c.Double(),
                        User_user_Id = c.Int(),
                        User_user_Id1 = c.Int(),
                    })
                .PrimaryKey(t => new { t.user_Id_1, t.user_Id_2 })
                .ForeignKey("dbo.Users", t => t.User_user_Id)
                .ForeignKey("dbo.Users", t => t.User_user_Id1)
                .Index(t => t.User_user_Id)
                .Index(t => t.User_user_Id1);
            
            CreateTable(
                "dbo.User_Item_Rating",
                c => new
                    {
                        user_Id = c.Int(nullable: false),
                        item_Id = c.Int(nullable: false),
                        Rating = c.Double(),
                    })
                .PrimaryKey(t => new { t.user_Id, t.item_Id })
                .ForeignKey("dbo.Items", t => t.item_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_Id, cascadeDelete: true)
                .Index(t => t.user_Id)
                .Index(t => t.item_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.user_Id);
            
            CreateTable(
                "dbo.User_Rating_Average",
                c => new
                    {
                        user_Id = c.Int(nullable: false),
                        Average = c.Double(),
                    })
                .PrimaryKey(t => t.user_Id)
                .ForeignKey("dbo.Users", t => t.user_Id)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Item_Rating", "user_Id", "dbo.Users");
            DropForeignKey("dbo.User_Rating_Average", "user_Id", "dbo.Users");
            DropForeignKey("dbo.Pearson_Score", "User_user_Id1", "dbo.Users");
            DropForeignKey("dbo.Pearson_Score", "User_user_Id", "dbo.Users");
            DropForeignKey("dbo.User_Item_Rating", "item_Id", "dbo.Items");
            DropIndex("dbo.User_Rating_Average", new[] { "user_Id" });
            DropIndex("dbo.User_Item_Rating", new[] { "item_Id" });
            DropIndex("dbo.User_Item_Rating", new[] { "user_Id" });
            DropIndex("dbo.Pearson_Score", new[] { "User_user_Id1" });
            DropIndex("dbo.Pearson_Score", new[] { "User_user_Id" });
            DropTable("dbo.User_Rating_Average");
            DropTable("dbo.Users");
            DropTable("dbo.User_Item_Rating");
            DropTable("dbo.Pearson_Score");
            DropTable("dbo.Items");
        }
    }
}
