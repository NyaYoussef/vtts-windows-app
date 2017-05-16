using App.Gwin.Attributes;
using App.Gwin.Entities;
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
    public  class Scale:BaseEntity
    {
        [EntryForm(Ordre = 3, GroupeBox = "Scales")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public int Number { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Scales")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Grade Grade { get; set; }

        
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public List<AdvancementScale> AdvancementScales { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Number != null )
                    return Number+"";
                else
                {
                    return "";
                }

            }
        }
    }
}
