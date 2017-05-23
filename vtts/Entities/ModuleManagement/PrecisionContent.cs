using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.SessionManagement;

namespace vtts.Entities.ModuleManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(Width = 880, Height = 600, TitrePageGridView = "grid_title")]
    public class PrecisionContent:BaseEntity
    {
        public PrecisionContent()
        {
            Goal = new LocalizedString();
            Description = new LocalizedString();
        }
        [EntryForm(WidthControl = 300, Ordre = 1)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(WidthControl = 150, Ordre = 2,isDefaultIsEmpty =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  Precision Precision { set; get; }

        [EntryForm(WidthControl =300,MultiLine =true,NumberLine =3,Ordre =2)]
        [DataGrid(WidthColonne =150,Ordre =0)]
        [Filter(WidthControl= 150,Ordre =1)]
        public LocalizedString Goal{ set; get; }

        [EntryForm(WidthControl = 200, Ordre = 0)]
        [DataGrid(WidthColonne = 80, Ordre = 1)]
        [Filter(WidthControl = 150, Ordre = 1)]
        public int Duration { set; get; }

        [EntryForm(WidthControl = 300, MultiLine = true, NumberLine = 6, Ordre = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(WidthControl = 150, Ordre = 3)]
        public LocalizedString Description { set; get; }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public List <Forecast> Forecasts { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Precision != null && Goal != null)
                    return Precision + " : " + Goal.Current;
                else
                {
                    return "";
                }

            }
        }


    }
}
