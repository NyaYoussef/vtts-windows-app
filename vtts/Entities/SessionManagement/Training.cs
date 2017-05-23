using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using vtts.Entities.StaffManagement;
using vtts.Entities.TraineeManagement;
using vtts.Entities.TrainingManagement;

namespace vtts.Entities.SessionManagement
{
    [GwinEntity(Localizable =true ,isMaleName =false,DisplayMember ="Code")]
    [Menu(Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =1020,Height =650)]
    public class Training : BaseEntity
   {
        [EntryForm(WidthControl =300,Ordre =1)]
        [DataGrid(WidthColonne =150,Ordre =1)]
        [Filter(Ordre =1,WidthControl =150,isDefaultIsEmpty =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public TrainingYear TrainingYear { set; get; }

    //    [EntryForm(WidthControl = 150, Ordre = 2)]
        [DataGrid(WidthColonne = 100, Ordre = 2)]
    //    [Filter(Ordre = 2, WidthControl = 150, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Specialty Specialty { set; get; }

        [EntryForm(WidthControl = 300, Ordre = 3)]
        [DataGrid(WidthColonne = 100, Ordre = 3)]
        [Filter(Ordre = 3, WidthControl = 150, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Module Module { set; get; }

        [EntryForm(WidthControl = 250, Ordre = 0)]
        [DataGrid(WidthColonne = 80, Ordre = 0)]
        [Filter(Ordre = 0, WidthControl = 100)]
        public String Code { set; get; }

        [EntryForm(WidthControl = 300, Ordre = 4)]
        [DataGrid(WidthColonne = 100, Ordre = 4)]
        [Filter(Ordre = 4, WidthControl = 150, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Group Group { set; get; }

        [EntryForm(WidthControl = 300, Ordre = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 5)]
        [Filter(Ordre = 5, WidthControl = 150, isDefaultIsEmpty = true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public Former Former { set; get; }
 
        
   
   }
}