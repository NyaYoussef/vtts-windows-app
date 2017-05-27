using App.Gwin.Attributes;
using App.Gwin.Entities;
using vtts.Entities.InstitutionManagement;
using vtts.Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "AdvanceManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =600,Height =500)]
    public class AdvancementEchelon:BaseEntity
    {
        [EntryForm(Ordre = 3, GroupeBox = "AdvancementEchlons")]
        [DataGrid(WidthColonne = 150)]
        

        public DateTime Date { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Former Former { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "AdvancementEchlons")]
        [DataGrid(WidthColonne =90)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =1,isDefaultIsEmpty =true, WidthControl = 130)]
        public  Echelon Echelon { get; set; }

       

        [EntryForm(Ordre = 4, GroupeBox = "AdvancementEchlons")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(isDefaultIsEmpty = true, WidthControl = 130)]
        public virtual Staff Staff { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Echelon != null &&  Date != null)
                    return Echelon+ ":" + Date.ToShortDateString();
                else
                {
                    return "";
                }

            }
        }

    }
}
