﻿namespace App
{
    using Entities.TraineeManagement;
    using Entities.TrainingManagement;
    using Gwin.Entities.Application;
    using Gwin.Entities.ContactInformations;
    using Gwin.Entities.Logging;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    public class ModelContext : DbContext
    {

        public ModelContext() : base(@"data source =(LocalDb)\MSSQLLocalDB; initial catalog = vocational-training-tracking-system; integrated security=True; MultipleActiveResultSets = True; App = EntityFramework")
        {
          
        }
        public ModelContext(string connectionString) : base(connectionString)
        {

        }

        //public ModelContext(string connectionString):base(connectionString)
        //{

        //}

        //
        // WinForm : Authentication
        //
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<GwinActivity> GwinActivities { get; set; }

        //
        // WinFrom : Application
        //
        public virtual DbSet<ApplicationName> ApplicationNames { get; set; }
        public virtual DbSet<MenuItemApplication> MenuItemApplications { get; set; }

        //
        // WinForm : ContactInformationss
        // 
        public virtual DbSet<Country> Countrys { get; set; }
        public virtual DbSet<City> Citys { get; set; }
        
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }


        ////
        //// Project management system
        ////
        //public virtual DbSet<Project> Projets { get; set; }
        //public virtual DbSet<ProjectTask> Taches { get; set; }
        //public virtual DbSet<ProjectCategory> ProjectCategorys { get; set; }
        //public virtual DbSet<RessouceProject> RessouceProjects { get; set; }

        //
        // Vacationel Tranning Tracking System : TraineeManagement
        //
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        //
        // Vacationel Tranning Tracking System : TrainingManagement
        //
        public virtual DbSet<Specialty> Specialties { get; set; }

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