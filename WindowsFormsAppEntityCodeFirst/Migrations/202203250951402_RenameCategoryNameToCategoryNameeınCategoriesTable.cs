namespace WindowsFormsAppEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCategoryNameToCategoryNameeınCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryNamee", c => c.String());
            AddColumn("dbo.Categories", "CategoryDetail", c => c.String());
            DropColumn("dbo.Categories", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            DropColumn("dbo.Categories", "CategoryDetail");
            DropColumn("dbo.Categories", "CategoryNamee");
        }
    }
}
