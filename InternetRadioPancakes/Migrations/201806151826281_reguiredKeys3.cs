namespace InternetRadioPancakes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reguiredKeys3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Title", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Title" });
            DropPrimaryKey("dbo.Categories");
            AddColumn("dbo.Categories", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Posts", "Category_ID", c => c.Int());
            AlterColumn("dbo.Categories", "Title", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AddPrimaryKey("dbo.Categories", "ID");
            CreateIndex("dbo.Posts", "Category_ID");
            AddForeignKey("dbo.Posts", "Category_ID", "dbo.Categories", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Category_ID" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Posts", "Title", c => c.String(maxLength: 128));
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Posts", "Category_ID");
            DropColumn("dbo.Categories", "ID");
            AddPrimaryKey("dbo.Categories", "Title");
            CreateIndex("dbo.Posts", "Title");
            AddForeignKey("dbo.Posts", "Title", "dbo.Categories", "Title");
        }
    }
}
