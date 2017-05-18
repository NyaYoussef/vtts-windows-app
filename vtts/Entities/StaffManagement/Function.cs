using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "Staffs", Title ="menu_title")]
    [ManagementForm(Width =720,TitrePageGridView ="grid_titel")]
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


        public virtual List<Staff> Staffs { get; set; }
    }
}
