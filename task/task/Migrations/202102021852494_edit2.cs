namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RXes", "date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RXes", "date", c => c.DateTime(storeType: "date"));
        }
    }
}
