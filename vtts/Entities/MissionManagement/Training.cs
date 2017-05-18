using App.Gwin.Attributes;
using App.Gwin.Entities.MultiLanguage;
using Entities.InstitutionManagement;
using Entities.StaffManagement;
using Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{

  /*  [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "MissionManagement")]*/
    public  class Training:MissionConvocation
    {
        public Training()
        {
            this.Subject = new LocalizedString();
        }

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        public LocalizedString Subject { get; set; }
        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public List<Module> Modules { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Former Former { get; set; }
    }
}
