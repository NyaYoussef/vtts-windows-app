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
    public  class Institution:BaseEntity
    {
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string Name { get; set; }
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string Address { set; get; }
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string Specialization { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]

        public List<Affectation> Affectations { get; set; }
    }
}
