namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writertitle_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 50));
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 20));
            DropColumn("dbo.Writers", "WiterName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WiterName", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterTitle");
            DropColumn("dbo.Writers", "WriterName");
        }
    }
}
