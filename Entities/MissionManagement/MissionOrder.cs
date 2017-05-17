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
    [ManagementForm(Width =1250,Height =650,TitrePageGridView ="Order_management",TitreButtonAjouter ="Add_order_mission")]
    public class MissionOrder: BaseEntity
    {
      
        [EntryForm(WidthControl =100,Ordre =0,GroupeBox = "Convocations",GroupeBoxOrder =0)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionConvocation Mission { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Convocations",GroupeBoxOrder =0)]
        [DataGrid(Ordre = 1, WidthColonne = 150)]
        [Filter(Ordre =1)]
        public string OrderNumber { set; get; }

        [EntryForm(Ordre = 0, WidthControl = 200,GroupeBox ="Date",GroupeBoxOrder =2)]
        [DataGrid(Ordre = 3, WidthColonne = 150)]
        public DateTime DepartureDate { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox ="Date",GroupeBoxOrder =2)]
        [DataGrid(Ordre = 4, WidthColonne = 150)]
        public DateTime ArrivalDate { set; get; }


        // Means of transport
        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Meansoftransport", GroupeBoxOrder = 1)]
        [DataGrid(Ordre = 2, WidthColonne = 250)]
        public MeansTransportCategories MeansTransportCategory { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Convocations", GroupeBoxOrder = 0)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Staff Staff { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Meansoftransport", GroupeBoxOrder = 1)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public virtual Car Car { get; set; }

        [EntryForm(Ordre = 7, WidthControl = 200,GroupeBox = "Validations", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 7, WidthColonne = 100)]
        public bool Validation { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public int DepartureTime { get; set; }

        [EntryForm(Ordre = 3, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public int  ArrivingTime { get; set; }

        [EntryForm(Ordre = 7, WidthControl = 100, GroupeBox = "Validations", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 7, WidthColonne = 100)]
        public DateTime ValidationDate { get; set; }

        [EntryForm(Ordre = 0, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public DateTime DateOrder { get; set; }


    }
}
