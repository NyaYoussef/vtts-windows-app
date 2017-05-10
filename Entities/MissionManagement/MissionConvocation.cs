using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using Entities.InstitutionManagement;
using Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "MissionManagement")]
    public class MissionConvocation: BaseEntity
    {
        public MissionConvocation()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();

        }


        [EntryForm(Ordre = 1)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2, MultiLine = true, WidthControl = 300)]
        [DataGrid(WidthColonne = 200)]
        [Filter]
        public LocalizedString Description { get; set; }


        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Staff> Staffs { get; set; }


        public Institution Institution { get; set; }
        //Sujet
        public MissionSubject MissionSubject { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public MissionCategory MissionCategory { get; set; }


        public List<MissionOrder> MissionOrders { get; set; }
    } 
}
