  namespace App.Migrations
{
    using vtts.Entities.AdvancementManagement;
    using vtts.Entities.InstitutionManagement;
    using vtts.Entities.MissionManagement;
    using vtts.Entities.SessionManagement;
    using vtts.Entities.StaffManagement;
    using vtts.Entities.TraineeManagement;
    using vtts.Entities.TrainingManagement;
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
    using vtts.Entities.ModuleManagement;
    using vtts.Entities.PlaningManagement;
    using vtts.Entities.ProjectManagement;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AppGestionStagiaires.ModelStagiaires";
        }

        protected override void Seed(App.ModelContext context)
        {
            // 
            // Gwin Application Name
            //
                context.ApplicationNames.AddOrUpdate(
                                r => r.Reference
                             ,
                             new App.Gwin.Entities.Application.ApplicationName
                             {
                                 Reference = "Vocational Training Tracking-System",
                                 Name = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "نظام تتبع التدريب المهني", English = "Vocational Training Tracking System", French = "Système de suivi de la formation professionnelle" }
                             }

                       );
            //
            // Gwin Roles
            //
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
              new Role { Reference = "Director", Name = new Gwin.Entities.MultiLanguage.LocalizedString() { Current = "Director" }, Hidden = true }
            );
           
            context.SaveChanges();  // Save Change to Select RoleRoot and RoleGuest
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

            Authorization TrianeeAuthorisation = new Authorization();
            TrianeeAuthorisation.BusinessEntity = typeof(Trainee).FullName;

            RoleGuest.Authorizations = new List<Authorization>();
            RoleGuest.Authorizations.Add(FindUserAutorization);
            RoleGuest.Authorizations.Add(TrianeeAuthorisation);

            context.SaveChanges();

            //Admin Autorization
            RoleAdmin.Authorizations = new List<Authorization>();
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

            //add advancement Echelon Autorization
            Authorization AdvancementEchelonAutorization = new Authorization();
            AdvancementEchelonAutorization.BusinessEntity = typeof(AdvancementEchelon).FullName;
            RoleAdmin.Authorizations.Add(AdvancementEchelonAutorization);

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
            /* Authorization TrainingAutorization = new Authorization();
             TrainingAutorization.BusinessEntity = typeof(Training).FullName;
             RoleAdmin.Authorizations.Add(TrainingAutorization);*/

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

            //     // Add Staff Autorization
            Authorization InstitutionAutorization = new Authorization();
            InstitutionAutorization.BusinessEntity = typeof(Institution).FullName;
            RoleAdmin.Authorizations.Add(InstitutionAutorization);


            //Add Dirrector Autorization
            RoleDirector.Authorizations = new List<Authorization>();
            RoleDirector.Authorizations.Add(CityAutorization);
            RoleDirector.Authorizations.Add(CountryAutorization);
            RoleDirector.Authorizations.Add(CityAutorization);
            RoleDirector.Authorizations.Add(MissionConvocationAutorization);
            RoleDirector.Authorizations.Add(AffectationAutorization);
            // RoleDirector.Authorizations.Add(TrainingAutorization);
            RoleDirector.Authorizations.Add(ScaleAutorization);
            RoleDirector.Authorizations.Add(GradeAutorization);
            RoleDirector.Authorizations.Add(EchelonAutorization);
            RoleDirector.Authorizations.Add(AdvancementScaleAutorization);
            RoleDirector.Authorizations.Add(FunctionAutorization);
            RoleDirector.Authorizations.Add(StaffAutorization);
            RoleDirector.Authorizations.Add(InstitutionAutorization);
            RoleDirector.Authorizations.Add(AdvancementEchelonAutorization);
            RoleDirector.Authorizations.Remove(SpecialtyAutorization);


            Authorization MissionCategoryAutorization = new Authorization();
            MissionCategoryAutorization.BusinessEntity = typeof(MissionCategory).FullName;
            RoleDirector.Authorizations.Add(MissionCategoryAutorization);

            Authorization RegionAutorization = new Authorization();
            RegionAutorization.BusinessEntity = typeof(Region).FullName;
            RoleDirector.Authorizations.Add(RegionAutorization);

            Authorization MissionOrderAutorization = new Authorization();
            MissionOrderAutorization.BusinessEntity = typeof(MissionOrder).FullName;
            RoleDirector.Authorizations.Add(MissionOrderAutorization);

            Authorization ThemeCategoryAutorization = new Authorization();
            ThemeCategoryAutorization.BusinessEntity = typeof(ThemeCategory).FullName;
            RoleDirector.Authorizations.Add(ThemeCategoryAutorization);

            Authorization MissionAutorization = new Authorization();
            MissionAutorization.BusinessEntity = typeof(Mission).FullName;
            RoleDirector.Authorizations.Add(MissionAutorization);

            Authorization CarAutorization = new Authorization();
            CarAutorization.BusinessEntity = typeof(Car).FullName;
            RoleDirector.Authorizations.Add(CarAutorization);
            context.SaveChanges();
            RoleAdmin.Authorizations.Add(CarAutorization);
            RoleAdmin.Authorizations.Add(MissionCategoryAutorization);
            RoleAdmin.Authorizations.Add(MissionOrderAutorization);
            RoleAdmin.Authorizations.Add(ThemeCategoryAutorization);
            RoleAdmin.Authorizations.Add(RegionAutorization);
            RoleAdmin.Authorizations.Add(MissionAutorization);

            Authorization PrecisionAutorization = new Authorization();
            PrecisionAutorization.BusinessEntity = typeof(Precision).FullName;
            RoleAdmin.Authorizations.Add(PrecisionAutorization);

            Authorization PriorAutorization = new Authorization();
            PriorAutorization.BusinessEntity = typeof(Prior).FullName;
            RoleAdmin.Authorizations.Add(PriorAutorization);

            Authorization PrecisionContentAutorization = new Authorization();
            PrecisionAutorization.BusinessEntity = typeof(PrecisionContent).FullName;
            RoleAdmin.Authorizations.Add(PrecisionContentAutorization);

            Authorization HolidayAutorization = new Authorization();
            HolidayAutorization.BusinessEntity = typeof(Holiday).FullName;
            RoleAdmin.Authorizations.Add(HolidayAutorization);

            Authorization PlanningSessionAutorization = new Authorization();
            PlanningSessionAutorization.BusinessEntity = typeof(PlanningSession).FullName;
            RoleAdmin.Authorizations.Add(PlanningSessionAutorization);

            Authorization TimeTableAutorization = new Authorization();
            TimeTableAutorization.BusinessEntity = typeof(TimeTable).FullName;
            RoleAdmin.Authorizations.Add(TimeTableAutorization);


            Authorization AbsenceAutorization = new Authorization();
            AbsenceAutorization.BusinessEntity = typeof(Absence).FullName;
            RoleAdmin.Authorizations.Add(AbsenceAutorization);


            Authorization ActivityAutorization = new Authorization();
            ActivityAutorization.BusinessEntity = typeof(Activity).FullName;
            RoleAdmin.Authorizations.Add(ActivityAutorization);


            Authorization ActivityCategoryAutorization = new Authorization();
            ActivityCategoryAutorization.BusinessEntity = typeof(ActivityCategory).FullName;
            RoleAdmin.Authorizations.Add(ActivityCategoryAutorization);

            Authorization ForecastAutorization = new Authorization();
            ForecastAutorization.BusinessEntity = typeof(Forecast).FullName;
            RoleAdmin.Authorizations.Add(ForecastAutorization);

            Authorization PedagogyStrategyAutorization = new Authorization();
            PedagogyStrategyAutorization.BusinessEntity = typeof(PedagogyStrategy).FullName;
            RoleAdmin.Authorizations.Add(PedagogyStrategyAutorization);

            Authorization SequenceAutorization = new Authorization();
            SequenceAutorization.BusinessEntity = typeof(Sequence).FullName;
            RoleAdmin.Authorizations.Add(SequenceAutorization);

            Authorization SessionAutorization = new Authorization();
            SessionAutorization.BusinessEntity = typeof(Session).FullName;
            RoleAdmin.Authorizations.Add(SessionAutorization);

            Authorization TrainingAutorization = new Authorization();
            TrainingAutorization.BusinessEntity = typeof(Training).FullName;
            RoleAdmin.Authorizations.Add(TrainingAutorization);

            Authorization TrainingYearAutorization = new Authorization();
            TrainingYearAutorization.BusinessEntity = typeof(TrainingYear).FullName;
            RoleAdmin.Authorizations.Add(TrainingYearAutorization);

            Authorization ProjectAutorization = new Authorization();
            ProjectAutorization.BusinessEntity = typeof(Project).FullName;
            RoleAdmin.Authorizations.Add(ProjectAutorization);

            Authorization ProjectTaskAutorization = new Authorization();
            ProjectTaskAutorization.BusinessEntity = typeof(ProjectTask).FullName;
            RoleAdmin.Authorizations.Add(ProjectTaskAutorization);

            Authorization ClassroomAutorization = new Authorization();
            ClassroomAutorization.BusinessEntity = typeof(Classroom).FullName;
            RoleAdmin.Authorizations.Add(ClassroomAutorization);

            Authorization CategogiesClassroomAutorization = new Authorization();
            CategogiesClassroomAutorization.BusinessEntity = typeof(CategogiesClassroom).FullName;
            RoleAdmin.Authorizations.Add(CategogiesClassroomAutorization);

            Authorization MiniGroupAutorization = new Authorization();
            MiniGroupAutorization.BusinessEntity = typeof(MiniGroup).FullName;
            RoleAdmin.Authorizations.Add(MiniGroupAutorization);






            //     //
            //     //-- Giwn Users
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
                         new MenuItemApplication { Id = 4, Code = "Trainee", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "المتدرب", English = "Trainee Management", French = "Stagiaires" } },
                         new MenuItemApplication { Id = 5, Code = "InstitutionManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير المؤسسة", English = "Institution management", French = "Gestion de l'établissement" } },
                         new MenuItemApplication { Id = 6, Code = "HRManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير الموارد البشرية", English = "RH management", French = "Gestion RH" } },
                         new MenuItemApplication { Id = 8, Code = "AdvanceManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير الترقيات", English = "Advance management", French = "Aavancements" } },
                         new MenuItemApplication { Id = 8, Code = "Staffs", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير المستخدمين", English = "Staffs management", French = "Personnels" } },
                         new MenuItemApplication { Id = 7, Code = "MissionManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير المهام", English = "Mission management", French = "Missions" } },
                         new MenuItemApplication { Id = 9, Code = "SessionManagement", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير الحصص الدراسية", English = "Session management", French = "Gestion des sessions" } }
                         );


   

            //Add Specialy 
            context.Specialties.AddOrUpdate(
                         r => r.Reference
                      ,
            new Specialty()
            {
                Reference = "TDI",
                Title = new LocalizedString { Arab = "التنمية المعلوماتية", English = "development informatique", French = "Développement informatique" },
                Code = "TDI",
                Description = new LocalizedString { Arab = "", English = "", French = "" }
            }
            ,
             new Specialty()
             {
                 Reference = "TDM",
                 Title = new LocalizedString { Arab = "تطوير الوسائط المتعددة", English = "development multimedia", French = "Développement multimédia" },
                 Code = "TDM",
                 Description = new LocalizedString { Arab = "", English = "", French = "" }
             }
            ,
               new Specialty()
               {
                   Reference = "TRI",
                   Title = new LocalizedString { Arab = "شبكة الكمبيوتر", English = "Computer network", French = "Réseau informatique" },
                   Code = "TRI",
                   Description = new LocalizedString { Arab = "", English = "", French = "" }

               }
               ,
                new Specialty()
                {
                    Reference = "INFO",
                    Title = new LocalizedString { Arab = "مخطط المعلومات الرسومي", English = "infographic", French = "Infographique" },
                    Code = "INFO",
                    Description = new LocalizedString { Arab = "", English = "", French = "" }
                }
                ,
                 new Specialty()
                 {
                     Reference = "TMSIR",
                     Title = new LocalizedString { Arab = "صيانة ودعم تكنولوجيا المعلومات والشبكات", English = "Maintenance and Support for Computers and Networks", French = "Maintenance et Support Informatique et Réseaux" },
                     Code = "TMSIR",
                     Description = new LocalizedString { Arab = "", English = "", French = "" }
                 }
            );
            //add Mission subject
            context.MissionCategorys.AddOrUpdate(
                       r => r.Reference
                    ,
                 new MissionCategory()
                 {
                     Reference = "Meeting",
                     Name = new LocalizedString { Arab = "إجتماع", English = "Meeting", French = "Réunion" }
                 },
                 new MissionCategory()
                 {
                     Reference = "Improvement",
                     Name = new LocalizedString { Arab = "تحسين", English = "Improvement", French = "Perfectionnement" }
                 },
                  new MissionCategory()
                  {
                      Reference = "SkillsAssessment",
                      Name = new LocalizedString { Arab = "تقييم المهارات", English = "Skills Assessment", French = "Bilan De Compétences" }
                  }
                 );
            //Add Country
            context.Countrys.AddOrUpdate(
                r => r.Reference,
                new Country()
                {
                    Reference = "Morroco",
                    Name = new LocalizedString { Arab = "المغرب", French = "Maroc", English = "Morroco" }
                     ,
                    Description = new LocalizedString { Arab = "", French = "", English = "" }
                }
                     );

            context.SaveChanges();
            Country Morroco = context.Countrys.Where(r => r.Reference == "Morroco").SingleOrDefault();

            //ADD CITYS
            context.Citys.AddOrUpdate(
                 r => r.Reference
                 ,
                 new City()
                 {
                     Reference = "Tangier",
                     Name = new LocalizedString { Arab = "طنجة", French = "Tanger", English = "Tangier" }
                      ,
                     Description = new LocalizedString { Arab = "", French = "", English = "" },
                     Country = Morroco,
                 },
                  new City()
                  {
                      Reference = "Casablanca",
                      Name = new LocalizedString { Arab = "الدار البيضاء", French = "Casablanca", English = "Casablanca" }
                       ,
                      Description = new LocalizedString { Arab = "", French = "", English = "" },
                      Country = Morroco,
                  },
                  new City()
                  {
                      Reference = "Rabat",
                      Name = new LocalizedString { Arab = "الرباط", French = "Rabat", English = "Rabat" }
                       ,
                      Description = new LocalizedString { Arab = "", French = "", English = "" },
                      Country = Morroco,
                  },
                   new City()
                   {
                       Reference = "Tetouan",
                       Name = new LocalizedString { Arab = "تطوان", French = "Tétouan", English = "Tetouan" }
                        ,
                       Description = new LocalizedString { Arab = "", French = "", English = "" },
                       Country = Morroco,
                   },
                   new City()
                   {
                       Reference = "Asilah",
                       Name = new LocalizedString { Arab = "أصيلة", French = "Asilah", English = "Asilah" }
                       ,
                       Description = new LocalizedString { Arab = "", French = "", English = "" },
                       Country = Morroco,



                   }
                     );
            context.SaveChanges();

            //Add Default Region
            context.Regions.AddOrUpdate(
              r => r.Reference,
              new Region()
              {
                  Reference = "Grand-Casablanca-Nord",
                  Name = new LocalizedString { Arab = "", French = "Grand Casablanca Nord", English = "Grand Casablanca Nord" }
              },
                new Region()
                {
                    Reference = "Grand-Casablanca-Sud",
                    Name = new LocalizedString { Arab = "", French = "Grand Casablanca Sud", English = "Grand Casablanca Sud" }
                },
                 new Region()
                 {
                     Reference = "Tensift Atlantique",
                     Name = new LocalizedString { Arab = "", French = "Tensift Atlantique", English = "Tensift Atlantique" }
                 },
                  new Region()
                  {
                      Reference = "Provinces Du Sud",
                      Name = new LocalizedString { Arab = "", French = "Provinces Du Sud", English = "Provinces Du Sud" }
                  },
                    new Region()
                    {
                        Reference = "Souss Massa Darâa",
                        Name = new LocalizedString { Arab = "", French = "Souss Massa Darâa", English = "Souss Massa Darâa" }
                    }
                    ,
                    new Region()
                    {
                        Reference = "Centre Sud",
                        Name = new LocalizedString { Arab = "", French = "Centre Sud", English = "Centre Sud" }
                    }
                    ,
                    new Region()
                    {
                        Reference = "Chaouia Tadla",
                        Name = new LocalizedString { Arab = "", French = "Chaouia Tadla", English = "Chaouia Tadla" }
                    }
                    ,
                    new Region()
                    {
                        Reference = "Oriental",
                        Name = new LocalizedString { Arab = "", French = "Oriental", English = "Oriental" }
                    }
                    ,
                    new Region()
                    {
                        Reference = "Centre Nord",
                        Name = new LocalizedString { Arab = "", French = "Centre Nord", English = "Centre Nord" }
                    }
                    ,
                    new Region()
                    {
                        Reference = "Nord Ouest II",
                        Name = new LocalizedString { Arab = "", French = "Nord Ouest II", English = "Nord Ouest II" }
                    }
              );
            context.SaveChanges();

            //Institution
            Region Region_Nord_Ouest_II = context.Regions.Where(r => r.Reference == "Nord Ouest II").SingleOrDefault();
            context.Institutions.AddOrUpdate(
               r => r.Reference,
               new Institution()
               {
                   Reference = "ISMONTIC",
                   Description = new LocalizedString { Arab = "المعهد المتخصص في الوظيفة الخارجة والتكنولوجيات الجديدة والمعلومات والتواصل", French = "Institut Spécialisé dans les Métiers de l'Offshoring et les Nouvelles Technologies de l'information et de la  Communication", English = "Institute Specialized in Offshoring and New Information and Communication Technologies" }
                  ,
                   Name = new LocalizedString { Arab = "ISMONTIC", English = "ISMONTIC", French = "ISMONTIC" },
                   Address = new LocalizedString { Arab = "شارع القوات المسلحة الملكية، طنجة، المغرب", English = "Boulevard Royal Armed Forces, Tangier, Morocco", French = "Boulevard des Forces Armées Royales, Tanger, Maroc" },
                   Region = Region_Nord_Ouest_II
               }

               );

            context.SaveChanges();

            //Add Default Function 
            context.Functions.AddOrUpdate(
                   r => r.Reference,
                   new Function()
                   {
                       Reference = "Director",
                       Name = new LocalizedString { Arab = "مدير", French = "directeur", English = "Director" },
                       Description = new LocalizedString { Arab = "", French = "", English = "" }
                   },
                    new Function()
                    {
                        Reference = "DirectorOfPedagogy",
                        Name = new LocalizedString { Arab = "مدير بيداغوجي", French = "Directeur Pédagogie", English = "Director Of Pedagogy" },
                        Description = new LocalizedString { Arab = "", French = "", English = "" }
                    }
                    ,
                     new Function()
                     {
                         Reference = "Former",
                         Name = new LocalizedString { Arab = "مكون", French = "Formateur", English = "Former" },
                         Description = new LocalizedString { Arab = "", French = "", English = "" }
                     },
                      new Function()
                      {
                          Reference = "GeneralGuard",
                          Name = new LocalizedString { Arab = "حارس عام", French = "garde en", English = "General Guard" },
                          Description = new LocalizedString { Arab = "", French = "", English = "" }
                      },
                        new Function()
                        {
                            Reference = "Cleaner",
                            Name = new LocalizedString { Arab = "عامل النظافة", French = "Femme De Ménage", English = "Cleaner" },
                            Description = new LocalizedString { Arab = "", French = "", English = "" }
                        }
                        ,
                         new Function()
                         {
                             Reference = "BodyGuard",
                             Name = new LocalizedString { Arab = "حارس", French = "Homme De Guet", English = "Bodyguard" },
                             Description = new LocalizedString { Arab = "", French = "", English = "" }
                         }
                   );
            context.SaveChanges();

           
            
          

            //
            // Test Data
            //

            Function Former = context.Functions.Where(r => r.Reference == "Former").SingleOrDefault();

            //staff Add 30 Staff for Test
            for (int i = 0; i < 30; i++)
            {
                context.Staffs.AddOrUpdate(
                                 r => r.Reference,
                                 new Staff()
                                 {

                                     Id = i,
                                     FirstName = new LocalizedString { Arab = "مدني" + i, French = "Madani" + i, English = "Madani" + i },
                                     LastName = new LocalizedString { Arab = "مدني" + i, French = "Ali" + i, English = "Ali" + i },
                                     DateOfBirth = Convert.ToDateTime("02/02/1982"),
                                     CIN = "k45878",
                                     Email = "madani@outloo.fr",
                                     Address = "tanger-tanger maroc",
                                     FaceBook = "Madani El",
                                     Cellphone = "063547459",
                                     PhoneNumber = "8987458",
                                     DateRecruitment = Convert.ToDateTime("02/02/2016"),
                                     Reference = "Madani" + i,
                                     Sex = false,
                                     RegistrationNumber = "k45dl" + i,
                                     Cars = null,
                                     Affectations = null,
                                     Function = Former,
                                     City = null,
                                     Ordre = 2,
                                     ProfilePhoto = null,
                                     WebSite = "google.com"


                                 }

                                 );

            }
            //add default grades
            context.Grades.AddOrUpdate(
                r => r.Reference,
                new Grade()
                {
                    Reference = "A",
                    Description = new LocalizedString { Arab = "A", English = "A", French = "A" }
                    ,
                    Name = new LocalizedString { Arab = "كبار المسؤولين التنفيذيين", English = "Senior executives", French = "Cadres supérieur" }
                }
                ,
                 new Grade()
                 {
                     Reference = "B",
                     Description = new LocalizedString { Arab = "B", English = "B", French = "B" }
                    ,
                     Name = new LocalizedString { Arab = "الأطر الرئيسية", English = "Main frame", French = "Cadres principaux" }
                 },
                  new Grade()
                  {
                      Reference = "C",
                      Description = new LocalizedString { Arab = "C", English = "C", French = "C" }
                    ,
                      Name = new LocalizedString { Arab = "الأطر", English = "Frame", French = "Cadres" }
                  },
                   new Grade()
                   {
                       Reference = "D",
                       Description = new LocalizedString { Arab = "D", English = "D", French = "D" }
                    ,
                        Name= new LocalizedString { Arab = "التحكم الرئيسي", English = "Master's degree", French = "Maitrise principale" }
                   }
                   , new Grade()
                   {
                       Reference = "E",
                       Description = new LocalizedString { Arab = "E", English = "E", French = "E" }
                    ,
                        Name= new LocalizedString { Arab = "التحكم", English = "Mastery", French = "Maitrise" }
                   },
                    new Grade()
                    {
                        Reference = "F",
                        Description = new LocalizedString { Arab = "F", English = "F", French = "F" }
                    ,
                        Name = new LocalizedString { Arab = "الأداء الرئيسي ", English = "Main execution", French = "Exécution principale" }
                    },
                    new Grade()
                    {
                        Reference = "G",
                        Description = new LocalizedString { Arab = "G", English = "G", French = "G" }
                    ,
                        Name = new LocalizedString { Arab = "الأداء", English = "Execution", French = "Exécution" }
                    }
                );
            context.SaveChanges();
        }
    }
}
