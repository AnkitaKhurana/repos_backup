namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AuthorId = c.Guid(nullable: false),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        ArticleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Article_Id = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.Article_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Article_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FollowerId = c.Guid(nullable: false),
                        FollowingId = c.Guid(nullable: false),
                        User_Id = c.Guid(),
                        User2_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User2_Id)
                .Index(t => t.User_Id)
                .Index(t => t.User2_Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ArticleId = c.Guid(nullable: false),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Followings", "User2_Id", "dbo.Users");
            DropForeignKey("dbo.Followings", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Favorites", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Favorites", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Articles", "User_Id", "dbo.Users");
            DropIndex("dbo.Tags", new[] { "User_Id" });
            DropIndex("dbo.Followings", new[] { "User2_Id" });
            DropIndex("dbo.Followings", new[] { "User_Id" });
            DropIndex("dbo.Favorites", new[] { "User_Id" });
            DropIndex("dbo.Favorites", new[] { "Article_Id" });
            DropIndex("dbo.Comments", new[] { "ArticleId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Articles", new[] { "User_Id" });
            DropTable("dbo.Tags");
            DropTable("dbo.Followings");
            DropTable("dbo.Favorites");
            DropTable("dbo.Comments");
            DropTable("dbo.Users");
            DropTable("dbo.Articles");
        }
    }
}
