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
    [Menu(Group ="MissionManagement",Order =5,Title = "menu_title")]
    [ManagementForm(Width =730,TitrePageGridView ="grid_title")]
    public class MissionCategory: BaseEntity
    {
        public MissionCategory()
        {
            this.Description = new LocalizedString();
            Name = new LocalizedString();
        }

        [EntryForm(Ordre = 1, WidthControl = 300)]
        [DataGrid(Ordre = 1, WidthColonne = 200)]
        [Filter(Ordre = 1, WidthControl = 200)]
        public LocalizedString Name { get; set; }


        [EntryForm(Ordre = 2, WidthControl = 400,MultiLine = true)]
        [DataGrid(Ordre = 2, WidthColonne = 200)]
        [Filter(Ordre =2,WidthControl =200)]
        public LocalizedString Description { get; set; }


        public string Code { get; set; }

        public List< MissionConvocation> MissionConvocations { get; set; }
    }
}
