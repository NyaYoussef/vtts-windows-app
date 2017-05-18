using App.Gwin.Attributes;
using App.Gwin.Entities.Persons;
using vtts.Entities.InstitutionManagement;
using vtts.Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "HRManagement")]
    public class Former: Staff
    {
        //
        // Pedagogy
        //
        [EntryForm(Ordre = 3, GroupeBox = "Pedagogy")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Specialty Specialty { get; set; }

    }
}
