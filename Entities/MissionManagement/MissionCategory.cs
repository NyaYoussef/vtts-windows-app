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
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Type")]
    [Menu(Group ="MissionManagement")]
    public class MissionCategory: BaseEntity
    {
        public MissionCategory()
        {
            this.Description = new LocalizedString();
        }
        [EntryForm(Ordre = 5, WidthControl = 150,GroupeBox = "menu_title")]
        [DataGrid(Ordre = 5, WidthColonne = 100)]
        [Filter(Ordre =3)]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre = 2, WidthControl = 150, GroupeBox = "menu_title")]
        [DataGrid(Ordre = 2, WidthColonne = 100)]
        [Filter(Ordre = 2)]
        public string Code { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 150,GroupeBox = "menu_title")]
        [DataGrid(Ordre = 1, WidthColonne = 100)]
        [Filter(Ordre = 1)]
        public string Type { get; set; }

        
        public List<MissionConvocation> MissionConvocations { get; set; }
    }
}
