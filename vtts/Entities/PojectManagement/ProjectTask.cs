using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.TraineeManagement;

namespace vtts.Entities.ProjectManagement
{
   [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
   //[Menu(Group ="")]
   [ManagementForm(TitrePageGridView ="grid_title")]
   //[Ignore]
    public class ProjectTask : BaseEntity 
    {

       public ProjectTask()
        {
            Title = new LocalizedString();
            Description = new LocalizedString();
        }

       [EntryForm (WidthControl =200,Ordre =0,isRequired =true,MultiLine =true,NumberLine =2)]
       [DataGrid(WidthColonne =150,Ordre =0)]
       [Filter(Ordre =0,WidthControl =150)]
        public LocalizedString Title { set; get; }


        [EntryForm(WidthControl = 200, Ordre = 2, isRequired = true, MultiLine = true, NumberLine = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(Ordre = 2, WidthControl = 150)]
        public LocalizedString Description { set; get; }

        [EntryForm(WidthControl = 200, Ordre = 1)]
        [DataGrid(WidthColonne = 150, Ordre = 1)]
        [Filter(Ordre = 1, isDefaultIsEmpty = true, WidthControl = 150)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Project Project {set;get;}

        [EntryForm(WidthControl = 200, Ordre = 4)]
        [DataGrid(WidthColonne = 150, Ordre = 4)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public virtual List<Trainee> Trainees { get; set; }

        [EntryForm(WidthControl = 200, Ordre = 3)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(Ordre = 3, isDefaultIsEmpty  = true, WidthControl = 150)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MiniGroup MiniGroup { get; set; }


      

    }
}
