namespace InternetRadioPancakes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reguiredKeys1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Context = c.String(),
                        Category = c.String(),
                        Views = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        addedTime = c.DateTime(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Category_ID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
        }
    }
}
