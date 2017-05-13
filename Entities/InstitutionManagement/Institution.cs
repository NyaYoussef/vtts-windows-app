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
        [EntryForm(Ordre = 1,GroupeBox = "menu_title")]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =1)]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2, MultiLine = true, WidthControl = 300,GroupeBox = "menu_title")]
        [DataGrid(WidthColonne = 200)]
        [Filter(Ordre =4)]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre = 3,GroupeBox = "menu_title")]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =3)]
        public LocalizedString Address { set; get; }

        [EntryForm(Ordre = 3,WidthControl =300,Enable =true,GroupeBox = "menu_title")]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =2)]
        public Region Region { set; get; }




    }
}
