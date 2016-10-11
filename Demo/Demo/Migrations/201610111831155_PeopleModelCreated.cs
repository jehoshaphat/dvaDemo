namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PeopleModelCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        AddressOne = c.String(nullable: false, maxLength: 255),
                        AddressTwo = c.String(maxLength: 255),
                        City = c.String(nullable: false, maxLength: 40),
                        State = c.String(nullable: false, maxLength: 80),
                        Zip = c.String(nullable: false, maxLength: 40),
                        Country = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
