namespace EClothPoint.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changiongtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "Description", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.Int(nullable: false));
        }
    }
}
