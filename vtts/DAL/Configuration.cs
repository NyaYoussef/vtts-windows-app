namespace App.Migrations
{
    using Gwin.Entities.Secrurity.Autorizations;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AppGestionStagiaires.ModelStagiaires";
        }

        protected override void Seed(App.ModelContext context)
        {
           

        }
    }
}
