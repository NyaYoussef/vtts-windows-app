using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.ModuleManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(Width = 800, Height = 550, TitrePageGridView = "grid_title")]
    public class Prior:BaseEntity
    {
        public Prior()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
        [EntryForm(WidthControl= 300,Ordre =1)]
        [DataGrid(WidthColonne =150,Ordre =1)]
        [Filter(Ordre =1,isDefaultIsEmpty =true ,WidthControl =200)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  Precision Precision { set; get; }

        [EntryForm(WidthControl = 300, Ordre = 0)]
        [DataGrid(WidthColonne = 150, Ordre = 0)]
        [Filter(Ordre = 0, WidthControl = 200)]
        public LocalizedString Name { set; get; }

        [EntryForm(WidthControl = 300, Ordre = 1,MultiLine=true ,NumberLine =6)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(Ordre = 3, WidthControl = 200)]
        public LocalizedString Description { set; get; }
    }
}
