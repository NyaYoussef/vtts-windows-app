using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using vtts.Entities.MissionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using vtts.Entities.SessionManagement;
using vtts.Entities.ModuleManagement;

namespace vtts.Entities.TrainingManagement
{
    [GwinEntity(Localizable =true,isMaleName =true,DisplayMember ="Name")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =1050,Height =600)]
    public class Module : BaseEntity
    {
       
        public Module()
        {
          
            this.Name = new LocalizedString();
            this.Presentation = new LocalizedString();
            this.Competence = new LocalizedString();
            this.TeachingStrategy = new LocalizedString();
            this.Learning = new LocalizedString();
            this.Evaluation = new LocalizedString();
            this.Description = new LocalizedString();
            this.Specialtys = new List<Specialty>();
        }


        // 
        // Informations générale
        //
        [EntryForm(Ordre = 1, GroupeBox = "SingularName",WidthControl =150)]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =1,WidthControl =150)]
        public LocalizedString Name { set; get; }

        [EntryForm(Ordre = 3, GroupeBox = "SingularName",WidthControl =150)]
     //   [DataGrid(WidthColonne = 100)]
        public LocalizedString Competence { set; get; }


        [EntryForm(Ordre = 0, GroupeBox = "SingularName",WidthControl =150)]
        [DataGrid(WidthColonne = 80,Ordre =0)]
        [Filter(Ordre =0,WidthControl =150)]
        public String Code { set; get; }

        [EntryForm(Ordre = 5, GroupeBox = "SingularName",WidthControl =150)]
        [DataGrid(WidthColonne = 100,Ordre =2)]
        [Filter(Ordre =5,WidthControl =150)]
        public LocalizedString Presentation { set; get; }

        // 
        // Description pédagogique
        //
        [EntryForm(Ordre = 3, GroupeBox = "Details")]
        [DataGrid(WidthColonne = 150,Ordre =3)]
        [Filter(Ordre =3,WidthControl =150)]
        public LocalizedString TeachingStrategy { set; get; }

        [EntryForm(Ordre = 3, GroupeBox = "Details")]
        [DataGrid(WidthColonne = 100,Ordre =4)]
        public LocalizedString Learning { set; get; }

        [EntryForm(Ordre = 4, GroupeBox = "SingularName",WidthControl =150)]
        [DataGrid(WidthColonne = 100,Ordre =5)]
        [Filter(Ordre =4,WidthControl =150)]
        public LocalizedString Evaluation { set; get; }

        // 
        // Planning
        //
        /// <summary>
        /// La duré en Nombre d'heure
        /// </summary>
        ///  
        [DataGrid(WidthColonne = 80,Ordre =2)]
        [EntryForm(Ordre = 2, GroupeBox = "SingularName",WidthControl =150)]
        [Filter(Ordre =2,WidthControl =100)]
        public int Duration { set; get; }
        // 
        // Affectation
        //
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        [EntryForm(Ordre = 8, GroupeBox = "Details")]
        public List<Specialty> Specialtys { set; get; }

        // 
        // Description Technique
        //  
        [DataGrid]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToMany_Creation)]
        public  List<Precision> Precisions { set; get; }

        public  List<Forecast> Forecasts { set; get; }

        [EntryForm(Ordre = 6, GroupeBox = "SingularName",WidthControl =150)]
        //[DataGrid(WidthColonne = 100)]
        public LocalizedString Description { set; get; }

       [EntryForm(Ordre = 3, GroupeBox = "Details")]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Training> Trainings { get; set; }
    }
}