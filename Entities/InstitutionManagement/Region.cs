using App.Gwin.Attributes;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.InstitutionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "Configuration", Title = "menu_title")]
    public class Region
    {
        [EntryForm(Ordre = 1)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2, MultiLine = true, WidthControl = 300)]
        [DataGrid(WidthColonne = 200)]
        [Filter]
        public LocalizedString Description { get; set; }
    }
}