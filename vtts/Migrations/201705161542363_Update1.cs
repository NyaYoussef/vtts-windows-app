namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Echelons", "AdvancementScale_Id", "dbo.AdvancementScales");
            DropForeignKey("dbo.MissionConvocations", "Former_Id", "dbo.Staffs");
            DropForeignKey("dbo.Modules", "Training_Id", "dbo.MissionConvocations");
            DropIndex("dbo.Echelons", new[] { "AdvancementScale_Id" });
            DropIndex("dbo.MissionConvocations", new[] { "Former_Id" });
            DropIndex("dbo.Modules", new[] { "Training_Id" });
            CreateTable(
                "dbo.AdvancementEchelons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Echelon_Id = c.Long(),
                        Former_Id = c.Long(),
                        Scale_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Echelons", t => t.Echelon_Id)
                .ForeignKey("dbo.Staffs", t => t.Former_Id)
                .ForeignKey("dbo.Scales", t => t.Scale_Id)
                .Index(t => t.Echelon_Id)
                .Index(t => t.Former_Id)
                .Index(t => t.Scale_Id);
            
            CreateTable(
                "dbo.Missions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        MissionCategory_Id = c.Long(),
                        MissionOrder_Id = c.Long(),
                        MissionSubject_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MissionCategories", t => t.MissionCategory_Id)
                .ForeignKey("dbo.MissionOrders", t => t.MissionOrder_Id)
                .ForeignKey("dbo.MissionSubjects", t => t.MissionSubject_Id)
                .Index(t => t.MissionCategory_Id)
                .Index(t => t.MissionOrder_Id)
                .Index(t => t.MissionSubject_Id);
            
            AddColumn("dbo.Staffs", "Mission_Id", c => c.Long());
            AddColumn("dbo.Specialties", "Description_French", c => c.String());
            AddColumn("dbo.Specialties", "Description_English", c => c.String());
            AddColumn("dbo.Specialties", "Description_Arab", c => c.String());
            AddColumn("dbo.MissionOrders", "Validation", c => c.Boolean(nullable: false));
            AddColumn("dbo.MissionOrders", "Car_Id", c => c.Long());
            CreateIndex("dbo.Staffs", "Mission_Id");
            CreateIndex("dbo.MissionOrders", "Car_Id");
            AddForeignKey("dbo.MissionOrders", "Car_Id", "dbo.Cars", "Id");
            AddForeignKey("dbo.Staffs", "Mission_Id", "dbo.Missions", "Id");
            DropColumn("dbo.Echelons", "AdvancementScale_Id");
            DropColumn("dbo.Specialties", "Description");
            DropColumn("dbo.MissionConvocations", "Subject_French");
            DropColumn("dbo.MissionConvocations", "Subject_English");
            DropColumn("dbo.MissionConvocations", "Subject_Arab");
            DropColumn("dbo.MissionConvocations", "Discriminator");
            DropColumn("dbo.MissionConvocations", "Former_Id");
            DropColumn("dbo.Modules", "Training_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modules", "Training_Id", c => c.Long());
            AddColumn("dbo.MissionConvocations", "Former_Id", c => c.Long());
            AddColumn("dbo.MissionConvocations", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.MissionConvocations", "Subject_Arab", c => c.String());
            AddColumn("dbo.MissionConvocations", "Subject_English", c => c.String());
            AddColumn("dbo.MissionConvocations", "Subject_French", c => c.String());
            AddColumn("dbo.Specialties", "Description", c => c.String());
            AddColumn("dbo.Echelons", "AdvancementScale_Id", c => c.Long());
            DropForeignKey("dbo.Staffs", "Mission_Id", "dbo.Missions");
            DropForeignKey("dbo.Missions", "MissionSubject_Id", "dbo.MissionSubjects");
            DropForeignKey("dbo.Missions", "MissionOrder_Id", "dbo.MissionOrders");
            DropForeignKey("dbo.Missions", "MissionCategory_Id", "dbo.MissionCategories");
            DropForeignKey("dbo.MissionOrders", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.AdvancementEchelons", "Scale_Id", "dbo.Scales");
            DropForeignKey("dbo.AdvancementEchelons", "Former_Id", "dbo.Staffs");
            DropForeignKey("dbo.AdvancementEchelons", "Echelon_Id", "dbo.Echelons");
            DropIndex("dbo.Missions", new[] { "MissionSubject_Id" });
            DropIndex("dbo.Missions", new[] { "MissionOrder_Id" });
            DropIndex("dbo.Missions", new[] { "MissionCategory_Id" });
            DropIndex("dbo.MissionOrders", new[] { "Car_Id" });
            DropIndex("dbo.Staffs", new[] { "Mission_Id" });
            DropIndex("dbo.AdvancementEchelons", new[] { "Scale_Id" });
            DropIndex("dbo.AdvancementEchelons", new[] { "Former_Id" });
            DropIndex("dbo.AdvancementEchelons", new[] { "Echelon_Id" });
            DropColumn("dbo.MissionOrders", "Car_Id");
            DropColumn("dbo.MissionOrders", "Validation");
            DropColumn("dbo.Specialties", "Description_Arab");
            DropColumn("dbo.Specialties", "Description_English");
            DropColumn("dbo.Specialties", "Description_French");
            DropColumn("dbo.Staffs", "Mission_Id");
            DropTable("dbo.Missions");
            DropTable("dbo.AdvancementEchelons");
            CreateIndex("dbo.Modules", "Training_Id");
            CreateIndex("dbo.MissionConvocations", "Former_Id");
            CreateIndex("dbo.Echelons", "AdvancementScale_Id");
            AddForeignKey("dbo.Modules", "Training_Id", "dbo.MissionConvocations", "Id");
            AddForeignKey("dbo.MissionConvocations", "Former_Id", "dbo.Staffs", "Id");
            AddForeignKey("dbo.Echelons", "AdvancementScale_Id", "dbo.AdvancementScales", "Id");
        }
    }
}
