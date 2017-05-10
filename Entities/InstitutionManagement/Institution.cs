using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.InstitutionManagement
{

    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "Configuration",Title ="menu_title")]
    public  class Institution:BaseEntity
    {
        public Institution()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
            this.Address = new LocalizedString();
        }
        [EntryForm(Ordre = 1)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2, MultiLine = true, WidthControl = 300)]
        [DataGrid(WidthColonne = 200)]
        [Filter]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre = 3)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public LocalizedString Address { set; get; }

        [EntryForm(Ordre = 3)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public Region Region { set; get; }




    }
}
