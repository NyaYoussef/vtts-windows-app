
using App.Gwin.Attributes;
using App.Gwin.Entities;
using Entities.InstitutionManagement;
using Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "AdvanceManagement")]
    public class AdvancementScale:BaseEntity
    {

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
       
        [DataGrid(WidthColonne = 100)]
        public DateTime Date { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public Former Former { get; set; }


        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Scale Scale { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public List< Echelon> Echelons { get; set; }
    }
}
