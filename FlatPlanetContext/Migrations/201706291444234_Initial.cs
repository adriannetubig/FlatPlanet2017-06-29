namespace FlatPlanetContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counter",
                c => new
                    {
                        CounterId = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CounterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Counter");
        }
    }
}
