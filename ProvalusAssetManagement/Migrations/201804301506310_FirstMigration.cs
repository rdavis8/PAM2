namespace ProvalusAssetManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QRReaders",
                c => new
                    {
                        QRID = c.Int(nullable: false, identity: true),
                        QRCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QRID);
            
            AlterColumn("dbo.Inventories", "Date_Added", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inventories", "Date_Added", c => c.DateTime(nullable: false));
            DropTable("dbo.QRReaders");
        }
    }
}
