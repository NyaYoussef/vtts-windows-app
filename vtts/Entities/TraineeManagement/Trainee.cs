using App.Gwin.Attributes;
using App.Gwin.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vtts.Entities.ProjectManagement;

namespace vtts.Entities.TraineeManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "Trainee")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =1120)]
    public class Trainee : Person
    {
         
        public int State { set; get; }

        // Affectation
        [DisplayProperty(DisplayMember = "Nom")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 3,GroupeBox = "Assignments",WidthControl =200,GroupeBoxOrder =101)]
        [Filter(isDefaultIsEmpty  =true,Ordre =5,WidthControl =150)]
        [DataGrid(WidthColonne = 200,Ordre =20)]
        public  Group Group { set; get; }
        
        [EntryForm(Ordre =4,WidthControl =200,GroupeBox = "Assignments",GroupeBoxOrder =101)]
        [DataGrid(Ordre =20,WidthColonne =200)]
        [Filter(Ordre =4,WidthControl =150,isDefaultIsEmpty  =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  MiniGroup MiniGroup { set; get; }


        //// Gestion des tâches
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public virtual List<ProjectTask> ProjectTasks { set; get; }

    }
}

