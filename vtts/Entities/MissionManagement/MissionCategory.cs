using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group ="MissionManagement")]
    [ManagementForm(Width =720,TitrePageGridView ="grid_title")]
    public class MissionCategory: BaseEntity
    {
        public MissionCategory()
        {
            this.Description = new LocalizedString();
            Name = new LocalizedString();
        }
        public LocalizedString Name { get; set; }
        [EntryForm(Ordre = 5, WidthControl = 200,GroupeBox = "menu_title")]
        [DataGrid(Ordre = 5, WidthColonne = 200)]
        [Filter(Ordre =3,WidthControl =200)]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre = 2, WidthControl = 200, GroupeBox = "menu_title")]
        [DataGrid(Ordre = 2, WidthColonne = 200)]
        [Filter(Ordre = 2,WidthControl =200)]
        public string Code { get; set; }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public List< MissionConvocation> MissionConvocations { get; set; }
    }
}
