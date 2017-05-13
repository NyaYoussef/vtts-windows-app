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
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "SubjectName")]
    [Menu(Group = "MissionManagement")]
    public class MissionSubject: BaseEntity
    {
        public MissionSubject()
        {
            this.SubjectName = new LocalizedString();
        }
        [EntryForm(WidthControl=200)]
        [DataGrid(WidthColonne =200)]
        [Filter(WidthControl =200)]
        public LocalizedString SubjectName { set; get; }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public List<MissionConvocation> MissionConvocations { get; set; }


    }
}
