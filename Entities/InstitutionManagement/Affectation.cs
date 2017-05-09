using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.InstitutionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    public  class Affectation:BaseEntity
    {
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        public DateTime DateAffectation { get; set; }
    }
}
