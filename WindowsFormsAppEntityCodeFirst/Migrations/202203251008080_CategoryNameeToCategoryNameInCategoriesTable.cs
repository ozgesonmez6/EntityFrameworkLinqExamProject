namespace WindowsFormsAppEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryNameeToCategoryNameInCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            Sql("Update Categories Set CategoryName=CategoryNamee");
            DropColumn("dbo.Categories", "CategoryNamee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryNamee", c => c.String());
            Sql("Update Categories Set CategoryNamee=CategoryName");
            DropColumn("dbo.Categories", "CategoryName");
        }
    }
}
