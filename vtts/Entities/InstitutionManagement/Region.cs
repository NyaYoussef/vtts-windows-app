using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vtts.Entities.InstitutionManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "Configuration", Title = "menu_title",Order = 2)]
    [ManagementForm(Width =700,TitrePageGridView ="grid_titre")]
    public class Region:BaseEntity
    {
        public Region()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
        }
        [EntryForm(Ordre = 1,GroupeBox = "menu_title")]
        [DataGrid(WidthColonne = 100)]
        [Filter(WidthControl =150)]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2, MultiLine = true, WidthControl = 250,GroupeBox = "menu_title")]
        [DataGrid(WidthColonne = 200)]
        [Filter(WidthControl =150)]
        public LocalizedString Description { get; set; }

        public virtual List<Institution> Institutions { get; set; }
    }
}