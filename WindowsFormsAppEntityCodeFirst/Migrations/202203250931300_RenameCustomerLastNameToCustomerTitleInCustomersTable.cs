namespace WindowsFormsAppEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCustomerLastNameToCustomerTitleInCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTitle", c => c.String());
            DropColumn("dbo.Customers", "CustomerLastname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerLastname", c => c.String());
            DropColumn("dbo.Customers", "CustomerTitle");
        }
    }
}
