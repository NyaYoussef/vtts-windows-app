using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace vtts.Entities.TrainingManagement
{

    [GwinEntity(Localizable = true, DisplayMember = "Code")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(TitrePageGridView ="gri_title",Width =850)]
    public class Specialty : BaseEntity
    {

        public Specialty()
        {
            this.Title = new LocalizedString();
            Description = new LocalizedString();
        }

        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter(Ordre =1,WidthControl =150)]
        [DataGrid(WidthColonne = 150,Ordre =1)]
        public LocalizedString Title { set; get; }


        [EntryForm(Ordre = 0, WidthControl = 150)]
        [Filter(Ordre = 0, WidthControl = 150)]
        [DataGrid(Ordre = 0, WidthColonne =150)]
        public  String Code { set; get; }

        [EntryForm(Ordre = 3,MultiLine =true,NumberLine =10,WidthControl =300)]
        [DataGrid(WidthColonne =200,Ordre =3)]
        [Filter(Ordre =3,WidthControl =150)]
        public LocalizedString Description { set; get; }

         
        public List<TraineeManagement.Group> Groups { set; get; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public  List<Module> Modules { set; get; }
    }
}