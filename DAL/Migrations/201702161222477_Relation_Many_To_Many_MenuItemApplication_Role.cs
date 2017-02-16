namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relation_Many_To_Many_MenuItemApplication_Role : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "MenuItemApplication_Id", "dbo.MenuItemApplications");
            DropIndex("dbo.Roles", new[] { "MenuItemApplication_Id" });
            CreateTable(
                "dbo.RoleMenuItemApplications",
                c => new
                    {
                        Role_Id = c.Long(nullable: false),
                        MenuItemApplication_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.MenuItemApplication_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.MenuItemApplications", t => t.MenuItemApplication_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.MenuItemApplication_Id);
            
            DropColumn("dbo.Roles", "MenuItemApplication_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "MenuItemApplication_Id", c => c.Long());
            DropForeignKey("dbo.RoleMenuItemApplications", "MenuItemApplication_Id", "dbo.MenuItemApplications");
            DropForeignKey("dbo.RoleMenuItemApplications", "Role_Id", "dbo.Roles");
            DropIndex("dbo.RoleMenuItemApplications", new[] { "MenuItemApplication_Id" });
            DropIndex("dbo.RoleMenuItemApplications", new[] { "Role_Id" });
            DropTable("dbo.RoleMenuItemApplications");
            CreateIndex("dbo.Roles", "MenuItemApplication_Id");
            AddForeignKey("dbo.Roles", "MenuItemApplication_Id", "dbo.MenuItemApplications", "Id");
        }
    }
}
