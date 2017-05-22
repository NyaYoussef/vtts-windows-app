using App.Gwin.Attributes;
using App.Gwin.Entities;
using vtts.Entities.InstitutionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "Staffs")]
    [ManagementForm(Width =670,Height =500,TitrePageGridView ="grid_title")]
    public  class Affectation:BaseEntity
    {
        [EntryForm(Ordre = 1,WidthControl =350)]
        [DataGrid(WidthColonne = 130,Ordre =4)]
        public DateTime DateAffectation { get; set; }

        [EntryForm(Ordre = 1,WidthControl =350)]
        [DataGrid(WidthColonne = 100,Ordre =2)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =2,isDefaultIsEmpty =true)]
        public Institution Institution { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 350)]
        [DisplayProperty(DisplayMember = "RegistrationNumber")]
        [DataGrid(WidthColonne = 100,Ordre =0)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(isDefaultIsEmpty =true,Ordre =1)]
        public Staff Staff { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Institution != null && DateAffectation != null)
                    return Institution + ":" + DateAffectation.ToShortDateString();
                else
                {
                    return "";
                }

            }
        }
    }
}
