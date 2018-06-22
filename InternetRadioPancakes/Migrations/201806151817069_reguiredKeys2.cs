namespace InternetRadioPancakes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reguiredKeys2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Category_ID" });
            DropColumn("dbo.Posts", "Title");
            RenameColumn(table: "dbo.Posts", name: "Category_ID", newName: "Title");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Posts", "Title", c => c.String(maxLength: 128));
            AlterColumn("dbo.Posts", "Title", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Categories", "Title");
            CreateIndex("dbo.Posts", "Title");
            AddForeignKey("dbo.Posts", "Title", "dbo.Categories", "Title");
            DropColumn("dbo.Categories", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Posts", "Title", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Title" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Posts", "Title", c => c.Int());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.Categories", "Title", c => c.String());
            AddPrimaryKey("dbo.Categories", "ID");
            RenameColumn(table: "dbo.Posts", name: "Title", newName: "Category_ID");
            AddColumn("dbo.Posts", "Title", c => c.String());
            CreateIndex("dbo.Posts", "Category_ID");
            AddForeignKey("dbo.Posts", "Category_ID", "dbo.Categories", "ID");
        }
    }
}
