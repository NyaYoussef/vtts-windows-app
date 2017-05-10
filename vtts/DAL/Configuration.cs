  namespace App.Migrations
{
    using Entities.AdvancementManagement;
    using Entities.InstitutionManagement;
    using Entities.MissionManagement;
    using Entities.SessionManagement;
    using Entities.StaffManagement;
    using Entities.TraineeManagement;
    using Entities.TrainingManagement;
    using Gwin.Application.BAL;
    using Gwin.Entities.Application;
    using Gwin.Entities.ContactInformations;
    using Gwin.Entities.MultiLanguage;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using System;
    using System.Collections.Generic;
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
            // -------------------------------------
            // Giwn App V 0.08
            // -------------------------------------
            //-- Gwin Application Name
            context.ApplicationNames.AddOrUpdate(
                           r => r.Reference
                        ,
                        new App.Gwin.Entities.Application.ApplicationName
                        {
                            Reference = "Vocational Training Tracking-System",
                            Name = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "نظام تتبع التدريب المهني", English = "Vocational Training Tracking System", French = "Système de suivi de la formation professionnelle" }
                        }

                      );
            //Gwin Roles
            Role RoleGuest = null;
            Role RoleRoot = null;
            Role RoleAdmin = null;
            Role RoleTrainee = null;
            Role RoleDirector = null;
            context.Roles.AddOrUpdate(
                 r => r.Reference
                        ,
              new Role { Reference = nameof(Role.Roles.Guest), Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.Guest) } },
              new Role { Reference = nameof(Role.Roles.User), Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.User) } },
              new Role { Reference = nameof(Role.Roles.Admin), Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.Admin) } },
              new Role { Reference = nameof(Role.Roles.Root), Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.Root) }, Hidden = true },
              new Role { Reference = "Trainee", Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = "Trainee" }, Hidden = true },
              new Role { Reference = "Director", Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = "Director" },Hidden=true }
            );
            // Save Change to Select RoleRoot and RoleGuest
            context.SaveChanges();
            RoleRoot = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Root)).SingleOrDefault();
            RoleGuest = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Guest)).SingleOrDefault();
            RoleAdmin = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Admin)).SingleOrDefault();
            RoleTrainee = context.Roles.Where(r => r.Reference == "Trainee").SingleOrDefault();
            RoleDirector = context.Roles.Where(r => r.Reference == "Director").SingleOrDefault();

            // 
            // Giwn Autorizations
            //
            // Guest Autorization
            Authorization FindUserAutorization = new Authorization();
            FindUserAutorization.BusinessEntity = typeof(User).FullName;
            FindUserAutorization.ActionsNames = new List<string>();
            FindUserAutorization.ActionsNames.Add(nameof(IGwinBaseBLO.Recherche));

            RoleGuest.Authorizations = new List<Authorization>();
            RoleGuest.Authorizations.Add(FindUserAutorization);

          

            // Guest Autorization
            Authorization TrianeeAuthorisation = new Authorization();
            TrianeeAuthorisation.BusinessEntity = typeof(Trainee).FullName;
            RoleGuest.Authorizations.Add(TrianeeAuthorisation);

            context.SaveChanges();
            //Admin Autorization
            //add Trainee autorization to admin
            TrianeeAuthorisation.BusinessEntity = typeof(Trainee).FullName;
            RoleAdmin.Authorizations.Add(TrianeeAuthorisation);

            //add group autorization to admin
            Authorization GroupAuthorisation = new Authorization();
            GroupAuthorisation.BusinessEntity = typeof(Group).FullName;
            RoleAdmin.Authorizations.Add(GroupAuthorisation);

            //add city autorization to admin
            Authorization CityAutorization = new Authorization();
            CityAutorization.BusinessEntity = typeof(City).FullName;
            RoleAdmin.Authorizations.Add(CityAutorization);

            //add Country autorization to admin
            Authorization CountryAutorization = new Authorization();
            CountryAutorization.BusinessEntity = typeof(Country).FullName;
            RoleAdmin.Authorizations.Add(CountryAutorization);

            //add Specialty autorization to admin
            Authorization SpecialtyAutorization = new Authorization();
            SpecialtyAutorization.BusinessEntity = typeof(Specialty).FullName;
            RoleAdmin.Authorizations.Add(SpecialtyAutorization);

            //add Training year autorization to admin
            Authorization YearsOfTrainingAutorization = new Authorization();
            YearsOfTrainingAutorization.BusinessEntity = typeof(TrainingYear).FullName;
            RoleAdmin.Authorizations.Add(YearsOfTrainingAutorization);

            //add Advancement Scale Autorization
            Authorization AdvancementScaleAutorization = new Authorization();
            AdvancementScaleAutorization.BusinessEntity = typeof(AdvancementScale).FullName;
            RoleAdmin.Authorizations.Add(AdvancementScaleAutorization);

            //add Echelon Autorization
            Authorization EchelonAutorization = new Authorization();
            EchelonAutorization.BusinessEntity = typeof(Echelon).FullName;
            RoleAdmin.Authorizations.Add(EchelonAutorization);

            //add Grade Autorization
            Authorization GradeAutorization = new Authorization();
            GradeAutorization.BusinessEntity = typeof(Grade).FullName;
            RoleAdmin.Authorizations.Add(GradeAutorization);

            //add Scale Autorization
            Authorization ScaleAutorization = new Authorization();
            ScaleAutorization.BusinessEntity = typeof(Scale).FullName;
            RoleAdmin.Authorizations.Add(ScaleAutorization);

            //add Affectation Autorization
            Authorization AffectationAutorization = new Authorization();
            AffectationAutorization.BusinessEntity = typeof(Affectation).FullName;
            RoleAdmin.Authorizations.Add(AffectationAutorization);

            //add Mission Autorization
            Authorization MissionConvocationAutorization = new Authorization();
            MissionConvocationAutorization.BusinessEntity = typeof(MissionConvocation).FullName;
            RoleAdmin.Authorizations.Add(MissionConvocationAutorization);

            //add Training Autorization
            Authorization TrainingAutorization = new Authorization();
            TrainingAutorization.BusinessEntity = typeof(Training).FullName;
            RoleAdmin.Authorizations.Add(TrainingAutorization);

            //add Module Autorization
            Authorization ModuleAutorization = new Authorization();
            ModuleAutorization.BusinessEntity = typeof(Module).FullName;
            RoleAdmin.Authorizations.Add(ModuleAutorization);

            // Add Function Autorization
            Authorization FunctionAutorization = new Authorization();
            FunctionAutorization.BusinessEntity = typeof(Function).FullName;
            RoleAdmin.Authorizations.Add(FunctionAutorization);

            // Add Staff Autorization
            Authorization StaffAutorization = new Authorization();
            StaffAutorization.BusinessEntity = typeof(Staff).FullName;
            RoleAdmin.Authorizations.Add(StaffAutorization);

            // Add Staff Autorization
            Authorization InstitutionAutorization = new Authorization();
            InstitutionAutorization.BusinessEntity = typeof(Institution).FullName;
            RoleAdmin.Authorizations.Add(InstitutionAutorization);


            //
            //Add Dirrector Autorization
            //
            RoleDirector.Authorizations = new List<Authorization>();
            RoleDirector.Authorizations.Add(FindUserAutorization);
            RoleDirector.Authorizations.Add(CityAutorization);
            RoleDirector.Authorizations.Add(CountryAutorization);
            RoleDirector.Authorizations.Add(CityAutorization);
            RoleDirector.Authorizations.Add(MissionConvocationAutorization);
            RoleDirector.Authorizations.Add(AffectationAutorization);
            RoleDirector.Authorizations.Add(TrainingAutorization);
            RoleDirector.Authorizations.Add(ScaleAutorization);
            RoleDirector.Authorizations.Add(GradeAutorization);
            RoleDirector.Authorizations.Add(EchelonAutorization);
            RoleDirector.Authorizations.Add(AdvancementScaleAutorization);
            RoleDirector.Authorizations.Add(SpecialtyAutorization);
            RoleDirector.Authorizations.Add(FunctionAutorization);
            RoleDirector.Authorizations.Add(StaffAutorization);
            RoleDirector.Authorizations.Add(InstitutionAutorization);

            Authorization MissionCategoryAutorization = new Authorization();
            MissionCategoryAutorization.BusinessEntity = typeof(MissionCategory).FullName;
            RoleDirector.Authorizations.Add(MissionCategoryAutorization);

            Authorization RegionAutorization = new Authorization();
            RegionAutorization.BusinessEntity = typeof(Region).FullName;
            RoleDirector.Authorizations.Add(RegionAutorization);

            Authorization MissionOrderAutorization = new Authorization();
            MissionOrderAutorization.BusinessEntity = typeof(MissionOrder).FullName;
            RoleDirector.Authorizations.Add(MissionOrderAutorization);

            Authorization MissionSubjectAutorization = new Authorization();
            MissionSubjectAutorization.BusinessEntity = typeof(MissionSubject).FullName;
            RoleDirector.Authorizations.Add(MissionSubjectAutorization);

            Authorization CarAutorization = new Authorization();
            CarAutorization.BusinessEntity = typeof(Car).FullName;
            RoleDirector.Authorizations.Add(CarAutorization);
            context.SaveChanges();


            // Trainee Autorization
            RoleTrainee.Authorizations = new List<Authorization>();
            RoleTrainee.Authorizations.Add(GroupAuthorisation);
            RoleTrainee.Authorizations.Add(TrianeeAuthorisation);
            context.SaveChanges();




            //
            //-- Giwn Users
            context.Users.AddOrUpdate(
                u => u.Reference,
                new User() { Reference = nameof(User.Users.Root), Login = nameof(User.Users.Root), Password = nameof(User.Users.Root), LastName = new LocalizedString() { Current = nameof(User.Users.Root) }, Roles = new List<Role>() { RoleRoot } },
                new User() { Reference = nameof(User.Users.Admin), Login = nameof(User.Users.Admin), Password = nameof(User.Users.Admin), LastName = new LocalizedString() { Current = nameof(User.Users.Admin) }, Roles = new List<Role>() { RoleAdmin } },
                new User() { Reference = nameof(User.Users.Guest), Login = nameof(User.Users.Guest), Password = nameof(User.Users.Guest), LastName = new LocalizedString() { Current = nameof(User.Users.Guest) }, Roles = new List<Role>() { RoleGuest } },
                new User() { Reference = "user-demo", Login = "madani", Password = "madani", LastName = new LocalizedString() { Current = "madani" }, Roles = new List<Role>() { RoleTrainee } },
                new User() { Reference = "Director", Language = Gwin.GwinApp.Languages.fr, Login = "Director", Password = "Director", LastName = new LocalizedString() { Current = "Director" }, Roles = new List<Role>() { RoleDirector } }
                );
            //
            // Menu
            //
            context.MenuItemApplications.AddOrUpdate(
                            r => r.Code
                         ,
                         new MenuItemApplication { Id = 1, Code = "Configuration", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "إعدادات", English = "Configuration", French = "Configuration" } },
                         new MenuItemApplication { Id = 2, Code = "Admin", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير البرنامج", English = "Admin", French = "Administration" } },
                         new MenuItemApplication { Id = 3, Code = "Root", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "مصمم اليرنامج", English = "Application Constructor", French = "Rélisateur de l'application" } },
                         new MenuItemApplication { Id = 4, Code = "Trainee", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "المتدرب", English = "Trainee Management", French = "Gestion Des Stagiaire" } },
                         new MenuItemApplication { Id = 5, Code = "InstitutionManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير المؤسسة", English = "Institution Management", French = "Gestion de l'établissement" } },
                         new MenuItemApplication { Id = 6, Code = "HRManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير الموارد البشرية", English = "RH Management", French = "Gestion RH" } }

                         );


            //
            // Default Data
            //
            // Add Counties

            // Add Cities

            //Add Specialy 
            context.Specialties.AddOrUpdate(
                         r => r.Reference
                      ,
            new Specialty()
            {
                Reference = "TDI",
                Title = new LocalizedString { Arab = "التنمية المعلوماتية", English = "development informatique", French = "Développement informatique" },
                Code = "TDI",
            }
            ,
             new Specialty()
             {
                 Reference = "TDM",
                 Title = new LocalizedString { Arab = "تطوير الوسائط المتعددة", English = "development multimedia", French = "Développement multimédia" },
                 Code = "TDM",
             }
            ,
               new Specialty()
               {
                   Reference = "TRI",
                   Title = new LocalizedString { Arab = "شبكة الكمبيوتر", English = "Computer network", French = "Réseau informatique" },
                   Code = "TRI",
               }
               ,
                new Specialty()
                {
                    Reference = "INFO",
                    Title = new LocalizedString { Arab = "مخطط المعلومات الرسومي", English = "infographic", French = "Infographique" },
                    Code = "INFO",
                }
                ,
                 new Specialty()
                 {
                     Reference = "TMSIR",
                     Title = new LocalizedString { Arab = "صيانة ودعم تكنولوجيا المعلومات والشبكات", English = "Maintenance and Support for Computers and Networks", French = "Maintenance et Support Informatique et Réseaux" },
                     Code = "TMSIR",
                 }
            );
            //add Mission subject
            context.MissionSubjects.AddOrUpdate(
                       r => r.Reference
                    ,
                 new MissionSubject()
                 {
                     Reference= "Meeting",
                     SubjectName=new LocalizedString { Arab= "إجتماع", English= "Meeting",French= "Réunion" }
                 },
                 new MissionSubject()
                 {
                     Reference= "Improvement",
                     SubjectName =new LocalizedString { Arab = "تحسين", English = "Improvement", French = "Perfectionnement" }
                 },
                  new MissionSubject()
                  {
                      Reference = "SkillsAssessment",
                      SubjectName = new LocalizedString { Arab = "تقييم المهارات", English = "Skills Assessment", French = "Bilan De Compétences" }
                  }
                 );
            //Add Country
            context.Countrys.AddOrUpdate(
                r => r.Reference,
                new Country()
                {
                    Reference= "Morroco",
                    Name=new LocalizedString { Arab= "المغرب", French= "Maroc",English="Morroco"}
                     ,
                    Description = new LocalizedString { Arab = "", French = "", English = "" }
                }
                );
            //ADD CITYS
            context.Citys.AddOrUpdate(
                r => r.Reference
                ,
                new City()
                {
                    Reference = "Tangier",
                    Name = new LocalizedString { Arab = "طنجة", French = "Tanger", English = "Tangier" }
                     ,
                    Description = new LocalizedString { Arab = "", French = "", English = "" }
                },
                 new City()
                 {
                     Reference = "Casablanca",
                     Name = new LocalizedString { Arab = "الدار البيضاء", French = "Casablanca", English = "Casablanca" }
                      ,
                     Description = new LocalizedString { Arab = "", French = "", English = "" }
                 },
                 new City()
                 {
                     Reference = "Rabat",
                     Name = new LocalizedString { Arab = "الرباط", French = "Rabat", English = "Rabat" }
                      ,
                     Description = new LocalizedString { Arab = "", French = "", English = "" }
                 },
                  new City()
                  {
                      Reference = "Tetouan",
                      Name = new LocalizedString { Arab = "تطوان", French = "Tétouan", English = "Tetouan" }
                       ,
                      Description = new LocalizedString { Arab = "", French = "", English = "" }
                  },
                  new City()
                  {
                      Reference = "Asilah",
                      Name = new LocalizedString { Arab = "أصيلة", French = "Asilah", English = "Asilah" }
                      , Description = new LocalizedString { Arab="",French="",English=""}

                  }


                );


        }
    }
}
