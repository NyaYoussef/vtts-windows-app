using App.Gwin.Attributes;
using App.Gwin.Entities;
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
    public class Mission:BaseEntity
    {
        [EntryForm(Ordre =1,WidthControl =200)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public MissionSubject MissionSubject { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public List<Staff> Staffs { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionOrder MissionOrder { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionCategory MissionCategory { get; set; }

    }
}
