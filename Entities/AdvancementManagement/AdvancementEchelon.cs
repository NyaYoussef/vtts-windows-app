using App.Gwin.Attributes;
using App.Gwin.Entities;
using Entities.InstitutionManagement;
using Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "HRManagement")]
    public class AdvancementEchelon:BaseEntity
    {
        [EntryForm(Ordre = 3, GroupeBox = "AdvancementEchlons")]
        [DataGrid(WidthColonne = 100)]
        

        public DateTime Date { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "AdvancementEchlons")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Former Former { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "AdvancementEchlons")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =1,isValeurFiltreVide =true)]
        public  Echelon Echelon { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "AdvancementEchlons")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Scale Scale { get; set; }

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
