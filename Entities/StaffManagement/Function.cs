using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "HRManagement", Title ="menu_title")]
    public class Function : BaseEntity
    {
        public Function()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
        }

        [EntryForm(Ordre = 1,WidthControl =200)]
        [DataGrid(WidthColonne = 200)]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2,MultiLine = true, NumberLine =5, WidthControl = 300)]
        [DataGrid(WidthColonne = 200)]
        [Filter]
        public LocalizedString Description { get; set; }

    }
}
