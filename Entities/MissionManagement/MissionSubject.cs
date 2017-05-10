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
    public class MissionSubject: BaseEntity
    {
        public MissionSubject()
        {
            this.SubjectName = new LocalizedString();
        }
        public LocalizedString SubjectName { set; get; }
    }
}
