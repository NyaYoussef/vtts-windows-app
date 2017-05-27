using App.Gwin.Attributes;
using App.Gwin.Entities;
using vtts.Entities.MissionManagement.Enumeration;
using vtts.Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Presentation.PrintOrderMission;
using vtts.Presentation.MissionManagement;
using vtts.BAL;

namespace vtts.Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "OrderNumber")]
    [Menu(Group = "MissionManagement",Order =2,Title = "menu_title")]
    [ManagementForm(Width =1250,Height =650,TitrePageGridView ="Order_management",TitreButtonAjouter ="Add_order_mission")]
    [DataGridSelectedAction(Title = "Print", Description = "Print_Order_Mission", TypeOfForm = typeof(FormPrintOrderMission))]
    [PresentationLogic(TypePLO = typeof(Presentation.MissionManagement.MissionOrderPLO))]
    public class MissionOrder: BaseEntity
    {

        //
        // Convocations
        //
        [EntryForm(WidthControl = 200, Ordre = 0, GroupeBox = "Convocations", GroupeBoxOrder = 0)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre = 1, WidthControl = 150, isDefaultIsEmpty = true)]
        public virtual MissionConvocation MissionConvocation { set; get; }

        [EntryForm(Ordre = 1, WidthControl = 200, GroupeBox = "Convocations", GroupeBoxOrder = 1)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre = 1, WidthControl = 150, isDefaultIsEmpty  = true)]
        public virtual Staff Staff { set; get; }

        //
        // Date
        //
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


        [EntryForm(Ordre = 3, WidthControl = 50, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public int DepartureTime { get; set; }

        [EntryForm(Ordre = 5, WidthControl = 50, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public int ArrivingTime { get; set; }

        [EntryForm(Ordre = 0, WidthControl = 200, GroupeBox = "Date", GroupeBoxOrder = 2)]
        public DateTime DateOrder { get; set; }
        // 
        // Means of transport
        //
        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Meansoftransport", GroupeBoxOrder = 1)]
        [DataGrid(Ordre = 2, WidthColonne = 150)]
        [BusinesRole]
        // [Filter(Ordre =3)]:enumertion filter not yet impliment
        public MeansTransportCategories MeansTransportCategory { set; get; }

       

        [EntryForm(Ordre = 2, WidthControl = 200,GroupeBox = "Meansoftransport", GroupeBoxOrder = 1)]
        [Filter (isDefaultIsEmpty  = true)]
        
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public virtual Car Car { get; set; }


        //
        // Validations
        //

        [EntryForm(Ordre = 0, WidthControl = 200,GroupeBox = "Validations", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 7, WidthColonne = 80)]
        [Filter(Ordre =1,WidthControl =100)]
        public bool Validation { get; set; }


        [EntryForm(Ordre = 1, WidthControl = 100, GroupeBox = "Validations", GroupeBoxOrder = 3)]
        [DataGrid(Ordre = 7, WidthColonne = 150)]
        public DateTime ValidationDate { get; set; }

        

      
    }
}
