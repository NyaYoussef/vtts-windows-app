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
    public class Echelon:BaseEntity
    {
        public Echelon()
        {
            this.Description = new LocalizedString();
        }
        [EntryForm(Ordre = 3, GroupeBox = "Echlon",MultiLine =true,WidthControl =300)]
        [DataGrid(WidthColonne = 100)]
        public LocalizedString Description { get; set; }

    }
}
