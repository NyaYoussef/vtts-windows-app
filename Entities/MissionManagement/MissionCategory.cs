using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group ="MissionManagement")]
    public class MissionCategory: BaseEntity
    {
        public List<MissionConvocation> MissionConvocations { get; set; }
    }
}
