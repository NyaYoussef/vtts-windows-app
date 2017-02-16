namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecrutityTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Entity = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Action_Id = c.Long(),
                        Role_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actions", t => t.Action_Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Action_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Roles", "User_Id", c => c.Long());
            CreateIndex("dbo.Roles", "User_Id");
            AddForeignKey("dbo.Roles", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Users", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Role", c => c.String());
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Authorizations", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Authorizations", "Action_Id", "dbo.Actions");
            DropIndex("dbo.Authorizations", new[] { "Role_Id" });
            DropIndex("dbo.Authorizations", new[] { "Action_Id" });
            DropIndex("dbo.Roles", new[] { "User_Id" });
            DropColumn("dbo.Roles", "User_Id");
            DropTable("dbo.Actions");
            DropTable("dbo.Authorizations");
        }
    }
}
