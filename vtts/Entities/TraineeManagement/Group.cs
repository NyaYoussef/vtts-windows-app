using App.Gwin.Attributes;
using App.Gwin.Entities;
using vtts.Entities.SessionManagement;
using vtts.Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace vtts.Entities.TraineeManagement
{

    [GwinEntity(Localizable =true,isMaleName =true,DisplayMember = "Name")]
    [SelectionCriteria(typeof(Specialty))]
    [Menu(Group= "Trainee")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =740)]
    public class Group : BaseEntity
    {
        
        [EntryForm(Ordre = 0,WidthControl =250,isRequired =true)]
        [Filter(WidthControl =150,Ordre =0)]
        [DataGrid(WidthColonne = 150,Ordre =0)]
        public string Name { set; get; }

       
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 2,WidthControl =250)]
        [Filter(isDefaultIsEmpty = true,Ordre =2,WidthControl =150)]
        [DataGrid(WidthColonne = 150,Ordre =2)]
        public  TrainingYear TrainingYears { set; get; }

       
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 1,WidthControl =250)]
        [Filter(isDefaultIsEmpty =true,Ordre =1,WidthControl =150)]
        [DataGrid(WidthColonne = 100)]
        public  Specialty Specialty { set; get; }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public  List<MiniGroup> MiniGroups { get; set; }
    }
}
