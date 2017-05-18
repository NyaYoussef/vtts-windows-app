namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MissionSubjects", newName: "ThemeCategories");
            DropForeignKey("dbo.MissionConvocations", "MissionSubject_Id", "dbo.MissionSubjects");
            DropIndex("dbo.MissionConvocations", new[] { "MissionSubject_Id" });
            RenameColumn(table: "dbo.Missions", name: "MissionSubject_Id", newName: "ThemeCategory_Id");
            RenameIndex(table: "dbo.Missions", name: "IX_MissionSubject_Id", newName: "IX_ThemeCategory_Id");
            CreateTable(
                "dbo.ThemeCategoryMissionConvocations",
                c => new
                    {
                        ThemeCategory_Id = c.Long(nullable: false),
                        MissionConvocation_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ThemeCategory_Id, t.MissionConvocation_Id })
                .ForeignKey("dbo.ThemeCategories", t => t.ThemeCategory_Id, cascadeDelete: true)
                .ForeignKey("dbo.MissionConvocations", t => t.MissionConvocation_Id, cascadeDelete: true)
                .Index(t => t.ThemeCategory_Id)
                .Index(t => t.MissionConvocation_Id);
            
            AddColumn("dbo.MissionConvocations", "Theme", c => c.String());
            AddColumn("dbo.MissionCategories", "Name_French", c => c.String());
            AddColumn("dbo.MissionCategories", "Name_English", c => c.String());
            AddColumn("dbo.MissionCategories", "Name_Arab", c => c.String());
            AddColumn("dbo.MissionOrders", "DepartureTime", c => c.Int(nullable: false));
            AddColumn("dbo.MissionOrders", "ArrivingTime", c => c.Int(nullable: false));
            AddColumn("dbo.MissionOrders", "ValidationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MissionOrders", "DateOrder", c => c.DateTime(nullable: false));
            AddColumn("dbo.ThemeCategories", "Name_French", c => c.String());
            AddColumn("dbo.ThemeCategories", "Name_English", c => c.String());
            AddColumn("dbo.ThemeCategories", "Name_Arab", c => c.String());
            DropColumn("dbo.MissionConvocations", "MissionSubject_Id");
            DropColumn("dbo.MissionCategories", "Type");
            DropColumn("dbo.MissionOrders", "Date");
            DropColumn("dbo.ThemeCategories", "SubjectName_French");
            DropColumn("dbo.ThemeCategories", "SubjectName_English");
            DropColumn("dbo.ThemeCategories", "SubjectName_Arab");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ThemeCategories", "SubjectName_Arab", c => c.String());
            AddColumn("dbo.ThemeCategories", "SubjectName_English", c => c.String());
            AddColumn("dbo.ThemeCategories", "SubjectName_French", c => c.String());
            AddColumn("dbo.MissionOrders", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.MissionCategories", "Type", c => c.String());
            AddColumn("dbo.MissionConvocations", "MissionSubject_Id", c => c.Long());
            DropForeignKey("dbo.ThemeCategoryMissionConvocations", "MissionConvocation_Id", "dbo.MissionConvocations");
            DropForeignKey("dbo.ThemeCategoryMissionConvocations", "ThemeCategory_Id", "dbo.ThemeCategories");
            DropIndex("dbo.ThemeCategoryMissionConvocations", new[] { "MissionConvocation_Id" });
            DropIndex("dbo.ThemeCategoryMissionConvocations", new[] { "ThemeCategory_Id" });
            DropColumn("dbo.ThemeCategories", "Name_Arab");
            DropColumn("dbo.ThemeCategories", "Name_English");
            DropColumn("dbo.ThemeCategories", "Name_French");
            DropColumn("dbo.MissionOrders", "DateOrder");
            DropColumn("dbo.MissionOrders", "ValidationDate");
            DropColumn("dbo.MissionOrders", "ArrivingTime");
            DropColumn("dbo.MissionOrders", "DepartureTime");
            DropColumn("dbo.MissionCategories", "Name_Arab");
            DropColumn("dbo.MissionCategories", "Name_English");
            DropColumn("dbo.MissionCategories", "Name_French");
            DropColumn("dbo.MissionConvocations", "Theme");
            DropTable("dbo.ThemeCategoryMissionConvocations");
            RenameIndex(table: "dbo.Missions", name: "IX_ThemeCategory_Id", newName: "IX_MissionSubject_Id");
            RenameColumn(table: "dbo.Missions", name: "ThemeCategory_Id", newName: "MissionSubject_Id");
            CreateIndex("dbo.MissionConvocations", "MissionSubject_Id");
            AddForeignKey("dbo.MissionConvocations", "MissionSubject_Id", "dbo.MissionSubjects", "Id");
            RenameTable(name: "dbo.ThemeCategories", newName: "MissionSubjects");
        }
    }
}
