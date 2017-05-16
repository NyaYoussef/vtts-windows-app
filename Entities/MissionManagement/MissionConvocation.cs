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
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "MissionSubject")]
    [Menu(Group = "MissionManagement")]
    [ManagementForm(Width = 900,Height =650)]
    public class MissionConvocation: BaseEntity
    {
        public MissionConvocation()
        {
        }

        //
        // Subject
        //
        [EntryForm(Ordre = 1, WidthControl = 100, GroupeBox = "Subject" , GroupeBoxOrder = 1)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [DataGrid]
        [Filter(WidthControl = 150)]
        public MissionSubject MissionSubject { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 100, GroupeBox = "Subject", GroupeBoxOrder = 1)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [DataGrid]
        [Filter]
        public MissionCategory MissionCategory { get; set; }

        [EntryForm(Ordre = 2, WidthControl = 150, MultiLine = true, GroupeBox = "Subject", GroupeBoxOrder = 1)]
        public LocalizedString Description { get; set; }



        //
        // Participant
        //
        [EntryForm(Ordre=3,WidthControl =100,GroupeBox = "Participants", GroupeBoxOrder = 2)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        [SelectionCriteria(typeof(Function))]
        public List<Staff> Staffs { get; set; }



        //
        // Location
        //
        [EntryForm(Ordre = 4, WidthControl = 150, GroupeBox = "location", GroupeBoxOrder = 3)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [SelectionCriteria(typeof(Region))]
        [DataGrid]
        [Filter]
        public Institution Institution { get; set; }


        [EntryForm(Ordre=5,WidthControl =150,GroupeBox = "location", GroupeBoxOrder = 3)]
        [DataGrid(Ordre=5,WidthColonne =100)]
        public DateTime StartDate { get; set; }

        [EntryForm(Ordre = 6, WidthControl = 150,GroupeBox = "location", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 5, WidthColonne = 100)]
        public DateTime EndDate { get; set; }



        public List<MissionOrder> MissionOrders { get; set; }
    } 
}
