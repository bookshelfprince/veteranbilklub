namespace ClientSideProgramming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cars2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Cars", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Cars");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.String(),
                        Manufactor = c.String(),
                        Image = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Cars", "ApplicationUser_Id");
            AddForeignKey("dbo.Cars", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
