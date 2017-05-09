using App.Gwin.Attributes;
using App.Gwin.Entities;
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
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string Name { get; set; }
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        public string Description { get; set; }

        
    }
}
