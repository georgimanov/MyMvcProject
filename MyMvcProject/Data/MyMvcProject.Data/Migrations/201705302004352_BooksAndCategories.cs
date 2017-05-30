namespace MyMvcProject.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class BooksAndCategories : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Title = c.String(),
                        CategoryId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.IsDeleted);

            this.CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
        }

        public override void Down()
        {
            this.DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            this.DropIndex("dbo.Categories", new[] { "IsDeleted" });
            this.DropIndex("dbo.Books", new[] { "IsDeleted" });
            this.DropIndex("dbo.Books", new[] { "CategoryId" });
            this.DropTable("dbo.Categories");
            this.DropTable("dbo.Books");
        }
    }
}
