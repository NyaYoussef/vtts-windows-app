using App.Gwin.Attributes;
using App.Gwin.Entities.Persons;
using Entities.InstitutionManagement;
using Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.InstitutionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    public class Former: Person
    {
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        public DateTime DateRecruitment { get; set; }
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public List<Affectation> Affectations { get; set; }
        public override string ToString() => base.ToString();

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Specialty Specialty { get; set; }

 
    }
}
