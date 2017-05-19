using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using vtts.Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Gwin.Attributes;

namespace vtts.Entities.ModuleManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(Width = 670, Height = 500, TitrePageGridView = "grid_title")]
    public class Precision:BaseEntity
    {
        //InstitutionManagement
       
        public Precision()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
        [EntryForm(WidthControl =200,Ordre =0)]
        [DataGrid(WidthColonne =150,Ordre =0)]
        [Filter(WidthControl =150,Ordre =0)]
        public LocalizedString Name { set; get; }

        //
        // Duree
        //
        [EntryForm(WidthControl = 100, Ordre = 1)]
        [DataGrid(WidthColonne = 150, Ordre = 1)]
        [Filter(WidthControl = 150, Ordre = 1)]
        public int Duration { set; get; }

        [EntryForm(WidthControl = 200, Ordre = 5,MultiLine =true,NumberLine =6)]
        [DataGrid(WidthColonne = 200, Ordre = 5)]
        [Filter(WidthControl = 150, Ordre = 5)]
        public LocalizedString Description { set; get; }

        //
        // Module
        //
        [EntryForm(WidthControl = 200, Ordre = 2)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(WidthControl = 150, Ordre = 2,isValeurFiltreVide =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  Module Module { set; get; }



        //public virtual List<Prealable> Prealables { set; get; }
        [EntryForm(WidthControl = 200, Ordre = 3)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(WidthControl = 150, Ordre = 3, isValeurFiltreVide = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public  List<PrecisionContent> PrecisionContents { set; get; }
    }
}
