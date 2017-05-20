using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.TraineeManagement;

namespace vtts.Entities.SessionManagement
{//SessionManagement
    [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Name")]
    [Menu(Group = "SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title")]
    public class Absence:BaseEntity
    {
        public Absence()
        {
            CauseOfAbsence = new LocalizedString();
        }
        [EntryForm (WidthControl =150,Ordre =4)]
        [DataGrid (WidthColonne =150,Ordre =3)]
        public DateTime AbsenceDate { get; set; }

        [EntryForm (WidthControl=200,MultiLine =true ,NumberLine =5,Ordre =2 )]
        [DataGrid(Ordre =2,WidthColonne =150)]
        [Filter(WidthControl =150,Ordre =2)]
        public LocalizedString CauseOfAbsence { get; set; }

        [EntryForm(WidthControl = 150,Ordre = 0)]
        [DataGrid(Ordre = 0, WidthColonne = 150)]
        [Filter(WidthControl = 150, Ordre = 0,isValeurFiltreVide =true )]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public Trainee Trainee { get; set; }

        [EntryForm (Ordre =3)]
        [Filter(Ordre =3)]
        public bool Authorization { get; set; }

        [EntryForm(WidthControl = 150, Ordre = 1)]
        [DataGrid(Ordre = 1, WidthColonne = 150)]
        [Filter(WidthControl = 150, Ordre = 1, isValeurFiltreVide = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Session Session { get; set; }

    }
}
