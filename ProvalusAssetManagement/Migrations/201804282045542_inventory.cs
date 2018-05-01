namespace ProvalusAssetManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Inventories", "Serial_Number", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inventories", "Serial_Number", c => c.Int());
        }
    }
}
