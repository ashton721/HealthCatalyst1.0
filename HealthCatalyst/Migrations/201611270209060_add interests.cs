namespace HealthCatalyst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addinterests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "interests", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "interests");
        }
    }
}
