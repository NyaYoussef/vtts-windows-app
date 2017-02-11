namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTraineeTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Trainnes", newName: "Trainees");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Trainees", newName: "Trainnes");
        }
    }
}
