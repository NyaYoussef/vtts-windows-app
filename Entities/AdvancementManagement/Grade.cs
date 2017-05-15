using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "AdvanceManagement")]
    public class Grade:BaseEntity
    {
        public Grade()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
        }
        [EntryForm(Ordre = 3, GroupeBox = "Grades")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public LocalizedString Name { get; set; }
        [EntryForm(Ordre = 3, GroupeBox = "Grades",MultiLine =true,WidthControl =300)]
        [DataGrid(WidthColonne = 100)]
        public LocalizedString Description { get; set; }

        
    }
}
