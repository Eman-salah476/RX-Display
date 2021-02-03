namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RXes", "date", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RXes", "date", c => c.String());
        }
    }
}
