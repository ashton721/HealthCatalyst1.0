namespace HealthCatalyst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        personID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        streetAddress = c.String(),
                        zip = c.String(),
                        city = c.String(),
                        state = c.String(),
                        age = c.Int(nullable: false),
                        personImgPath = c.String(),
                    })
                .PrimaryKey(t => t.personID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
