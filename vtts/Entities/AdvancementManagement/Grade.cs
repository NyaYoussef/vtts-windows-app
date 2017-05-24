using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.StaffManagement;

namespace vtts.Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "AdvanceManagement")]
    [ManagementForm(Width =740,TitrePageGridView ="grid_title")]
    public class Grade:BaseEntity
    {
        public Grade()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
        }
        [EntryForm(Ordre = 3, GroupeBox = "Grades",WidthControl =150)]
        [DataGrid(WidthColonne = 200)]
        [Filter(Ordre =1 ,WidthControl = 200)]
        public LocalizedString Name { get; set; }
        [EntryForm(Ordre = 3, GroupeBox = "Grades",MultiLine =true,WidthControl =250)]
        [DataGrid(WidthColonne = 200)]
        [Filter(Ordre =2,WidthControl =200)]
        public LocalizedString Description { get; set; }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public List<Staff> Staffs { get; set; }

        
    }
}
