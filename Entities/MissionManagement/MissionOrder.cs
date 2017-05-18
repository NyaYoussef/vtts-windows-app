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
  //  [DataGridSelectedAction(Title = "Print", Description = "Print_Order_Mission", TypeOfForm = typeof())]
    public class MissionOrder: BaseEntity
    {
      
        [EntryForm(WidthControl =200,Ordre =0,GroupeBox = "Convocations",GroupeBoxOrder =0)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =1, WidthControl = 150)]
        public MissionConvocation Mission { set; get; }

        [EntryForm(Ordre = 1, WidthControl = 200,GroupeBox = "Date",GroupeBoxOrder =2)]
        [DataGrid(Ordre = 1, WidthColonne = 120)]
        [Filter(Ordre =0, WidthControl = 100)]
        public string OrderNumber { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox ="Date",GroupeBoxOrder =2)]
        [DataGrid(Ordre = 3, WidthColonne = 135)]
        public DateTime DepartureDate { set; get; }

        [EntryForm(Ordre = 4, WidthControl = 200,GroupeBox ="Date",GroupeBoxOrder =2)]
        [DataGrid(Ordre = 4, WidthColonne = 135)]
        public DateTime ArrivalDate { set; get; }


        // Means of transport
        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Meansoftransport", GroupeBoxOrder = 1)]
        [DataGrid(Ordre = 2, WidthColonne = 150)]
        [BusinesRole]
        // [Filter(Ordre =3)]:enumertion filter not yet impliment
        public MeansTransportCategories MeansTransportCategory { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Convocations", GroupeBoxOrder = 0)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =4, WidthControl = 150)]
        public Staff Staff { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Meansoftransport", GroupeBoxOrder = 1)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public virtual Car Car { get; set; }

        [EntryForm(Ordre = 7, WidthControl = 200,GroupeBox = "Validations", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 7, WidthColonne = 80)]
        [Filter(Ordre =1,WidthControl =100)]
        public bool Validation { get; set; }

        [EntryForm(Ordre = 3, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public int DepartureTime { get; set; }

        [EntryForm(Ordre = 5, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public int  ArrivingTime { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 100, GroupeBox = "Validations", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 7, WidthColonne = 150)]
        public DateTime ValidationDate { get; set; }

        [EntryForm(Ordre = 0, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public DateTime DateOrder { get; set; }

      
    }
}
