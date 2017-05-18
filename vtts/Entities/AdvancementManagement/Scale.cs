using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "HRManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =740)]
    public  class Scale:BaseEntity
    {
        [EntryForm(Ordre = 3, GroupeBox = "Scales")]
        [DataGrid(WidthColonne = 200)]
        [Filter(Ordre =1,WidthControl =200)]
        public int Number { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Scales",WidthControl =200)]
        [DataGrid(WidthColonne = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =2,isValeurFiltreVide =true,WidthControl =200)]
        public Grade Grade { get; set; }
        
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
