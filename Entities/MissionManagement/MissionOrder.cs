using App.Gwin.Attributes;
using App.Gwin.Entities;
using Entities.MissionManagement.Enumeration;
using Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "OrderNumber")]
    [Menu(Group = "MissionManagement")]
    public class MissionOrder: BaseEntity
    {
        [EntryForm(Ordre =2,WidthControl =150)]
        [DataGrid(Ordre =2,WidthColonne =100)]
        public DateTime Date { set; get; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionConvocation Mission { set; get; }

        [EntryForm(Ordre = 1, WidthControl = 150)]
        [DataGrid(Ordre = 1, WidthColonne = 100)]
        public string OrderNumber { set; get; }

        [EntryForm(Ordre = 3, WidthControl = 150)]
        [DataGrid(Ordre = 3, WidthColonne = 100)]
        public DateTime DepartureDate { set; get; }

        [EntryForm(Ordre = 4, WidthControl = 150)]
        [DataGrid(Ordre = 4, WidthColonne = 100)]
        public DateTime ArrivalDate { set; get; }


        // Means of transport
        [EntryForm(Ordre = 2, WidthControl = 200)]
        [DataGrid(Ordre = 2, WidthColonne = 100)]
        public MeansTransportCategories MeansTransportCategory { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 150)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Staff Staff { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public Car Car { get; set; }

        [EntryForm(Ordre = 7, WidthControl = 150)]
        [DataGrid(Ordre = 7, WidthColonne = 100)]
        public bool Validation { get; set; }
    }
}
