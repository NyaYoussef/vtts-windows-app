using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "MissionManagement")]
    public class ThemeCategory: BaseEntity
    {
        public ThemeCategory()
        {
            Name = new LocalizedString();
        }
        [EntryForm(WidthControl=200)]
        [DataGrid(WidthColonne =200)]
        [Filter(WidthControl =200)]
        public LocalizedString Name { set; get; }

        [Relationship(Relation =RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<MissionConvocation> MissionConvocations { get; set; }


    }
}
