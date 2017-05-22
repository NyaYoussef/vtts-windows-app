namespace App
{
    using vtts.Entities.AdvancementManagement;
    using vtts.Entities.InstitutionManagement;
    using vtts.Entities.MissionManagement;
    using vtts.Entities.StaffManagement;
    using vtts.Entities.TraineeManagement;
    using vtts.Entities.TrainingManagement;
    using Gwin.Entities.Application;
    using Gwin.Entities.ContactInformations;
    using Gwin.Entities.Logging;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using Spire.License;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;
    using vtts.Entities.ModuleManagement;
    using vtts.Entities.PlaningManagement;
    using vtts.Entities.SessionManagement;
    using vtts.Entities.ProjectManagement;

    public class ModelContext : DbContext
    {

        public ModelContext() : base(@"data source =(LocalDb)\MSSQLLocalDB; initial catalog = vocational-training-tracking-system; integrated security=True; MultipleActiveResultSets = True; App = EntityFramework")
        {
          
        }
        public ModelContext(string connectionString) : base(connectionString)
        {

        }

        // //public ModelContext(string connectionString):base(connectionString)
        // //{

        // //}

        // //
        // // WinForm : Authentication
        // //
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<GwinActivity> GwinActivities { get; set; }

        // //
        // // WinFrom : Application
        // //
        public virtual DbSet<ApplicationName> ApplicationNames { get; set; }
        public virtual DbSet<MenuItemApplication> MenuItemApplications { get; set; }

        // //
        // // WinForm : ContactInformationss
        // // 
        public virtual DbSet<Country> Countrys { get; set; }
        public virtual DbSet<City> Citys { get; set; }

        public virtual DbSet<ContactInformation> ContactInformations { get; set; }


        // ////
        // //// Project management system
        // ////
        //public virtual DbSet<Product> Projets { get; set; }
        //public virtual DbSet<ProjectTask> Taches { get; set; }
        //public virtual DbSet<ProjectCategory> ProjectCategorys { get; set; }
        //public virtual DbSet<RessouceProject> RessouceProjects { get; set; }

        // //
        // // Vacationel Tranning Tracking System : TraineeManagement
        // //
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Former> Formers { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        // //
        // // Vacationel Tranning Tracking System : TrainingManagement
        // //
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<AdvancementScale> AdvancementScaleS { get; set; }
        public virtual DbSet<Echelon> Echelons { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Scale> Scales { get; set; }
        public virtual DbSet<Affectation> Affectations { get; set; }
        public virtual DbSet<MissionConvocation> MissionConvocations { get; set; }
        // public virtual DbSet<Training>  Trainings{ get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<MissionCategory> MissionCategorys { get; set; }
        public virtual DbSet<MissionOrder> MissionOrders { get; set; }
        public virtual DbSet<ThemeCategory> ThemeCategorys { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<AdvancementEchelon> AdvancementEchelons { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<Precision> Precision { get; set; }
        public virtual DbSet<Prior> Priors { get; set; }
        public virtual DbSet<PrecisionContent> PrecisionContent { get; set; }
        public virtual  DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<PlanningSession> PlanningSessions { get; set; }
        public virtual DbSet<TimeTable> TimeTable { get; set; }
        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<Activity> Activitys { get; set; }
        public virtual DbSet<ActivityCategory> ActivityCategorys { get; set; }
        public virtual DbSet<Forecast> Forecasts { get; set; }
        public virtual DbSet<PedagogyStrategy> PedagogyStrategys { get; set; }
        public virtual DbSet<Sequence> Sequences { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<TrainingYear> TrainingYears { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<CategogiesClassroom> CategogiesClassrooms { get; set; }










        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }


        /// <summary>
        /// trouver la liste des type des objets dans le context
        /// </summary>
        /// <returns></returns>
        public List<Type> GetTypesSets()
        {
           
            var sets = from p in typeof(ModelContext).GetProperties() where p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) let entityType = p.PropertyType.GetGenericArguments().First() select p.PropertyType.GetGenericArguments()[0];
            return sets.ToList<Type>();
        }

    }

    


}