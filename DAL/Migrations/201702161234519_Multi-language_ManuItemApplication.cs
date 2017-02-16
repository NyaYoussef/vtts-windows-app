namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Multilanguage_ManuItemApplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItemApplications", "TitleArabic", c => c.String());
            AddColumn("dbo.MenuItemApplications", "TitleFrench", c => c.String());
            AddColumn("dbo.MenuItemApplications", "TitleEnglish", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItemApplications", "TitleEnglish");
            DropColumn("dbo.MenuItemApplications", "TitleFrench");
            DropColumn("dbo.MenuItemApplications", "TitleArabic");
        }
    }
}
