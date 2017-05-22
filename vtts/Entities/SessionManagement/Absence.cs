using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.TraineeManagement;

namespace vtts.Entities.SessionManagement
{//SessionManagement
    [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Name")]
    [Menu(Group = "SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Height =600)]
    public class Absence:BaseEntity
    {
        public Absence()
        {
            CauseOfAbsence = new LocalizedString();
        }
        [EntryForm (WidthControl =250,Ordre =2)]
        [DataGrid (WidthColonne =150,Ordre =3)]
        public DateTime AbsenceDate { get; set; }

        [EntryForm (WidthControl=300,MultiLine =true ,NumberLine =4,Ordre =4 )]
        [DataGrid(Ordre =2,WidthColonne =150)]
        [Filter(WidthControl =150,Ordre =2)]
        public LocalizedString CauseOfAbsence { get; set; }

        [EntryForm(WidthControl = 250,Ordre = 0)]
        [DataGrid(Ordre = 0, WidthColonne = 150)]
        [Filter(WidthControl = 150, Ordre = 0,isDefaultIsEmpty =true )]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public Trainee Trainee { get; set; }

        [EntryForm (Ordre =3)]
        [Filter(Ordre =3)]
        public bool Authorization { get; set; }

        [EntryForm(WidthControl = 250, Ordre = 1)]
        [DataGrid(Ordre = 1, WidthColonne = 150)]
        [Filter(WidthControl = 150, Ordre = 1, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Session Session { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Trainee != null && AbsenceDate != null)
                    return Trainee + ":" + AbsenceDate.ToShortDateString();
                else
                {
                    return "";
                }
            }
            
        }
            

    }
}
