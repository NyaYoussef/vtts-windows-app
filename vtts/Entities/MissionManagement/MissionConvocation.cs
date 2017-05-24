using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using vtts.Entities.InstitutionManagement;
using vtts.Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "MissionManagement", Order = 1, Title = "menu_title")]
    [ManagementForm(Width = 1100, Height = 650, TitrePageGridView = "title_gridview")]
    // [GwinForm(FormType = typeof(MissionConvocationFrom))]
    public class MissionConvocation : BaseEntity
    {
        public MissionConvocation()
        {
            this.Description = new LocalizedString();
        }

        //
        // Subject
        //
        [EntryForm(Ordre = 1, WidthControl = 200, GroupeBox = "Subject", GroupeBoxOrder = 1, isRequired = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]

        public virtual List<ThemeCategory> ThemeCategorys { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200, GroupeBox = "Subject", GroupeBoxOrder = 1, isRequired = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(Ordre = 6, isDefaultIsEmpty = true, WidthControl = 130)]
        public virtual MissionCategory MissionCategory { get; set; }

        [EntryForm(Ordre = 2, WidthControl = 200, MultiLine = true, GroupeBox = "Subject", GroupeBoxOrder = 1)]
        public LocalizedString Description { get; set; }


        [EntryForm(Ordre = 0, WidthControl = 200, GroupeBox = "Subject", GroupeBoxOrder = 1, isRequired = true)]
        [DataGrid(Ordre = 0, WidthColonne = 200)]
        [Filter(WidthControl = 300)]
        public LocalizedString Theme { get; set; }




        //
        // Participant
        //
        [EntryForm(Ordre = 3, WidthControl = 200, GroupeBox = "Participants", GroupeBoxOrder = 2, isRequired = true,HeightControl =260)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
       // [SelectionCriteria(typeof(Function))]
        public virtual List<Staff> Staffs { get; set; }



        //
        // Location
        //
        [EntryForm(Ordre = 4, WidthControl = 200, GroupeBox = "location", GroupeBoxOrder = 3, isRequired = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [SelectionCriteria(typeof(Region))]
        [DataGrid(Ordre = 14)]
        [Filter(Ordre = 3, isDefaultIsEmpty = true, WidthControl = 200)]
        public virtual Institution Institution { get; set; }


        [EntryForm(Ordre = 5, WidthControl = 200, GroupeBox = "location", GroupeBoxOrder = 3, isRequired = true)]
        [DataGrid(Ordre = 15, WidthColonne = 150)]
        public DateTime StartDate { get; set; }

        [EntryForm(Ordre = 6, WidthControl = 200, GroupeBox = "location", GroupeBoxOrder = 3, isRequired = true)]
        [DataGrid(Ordre = 15, WidthColonne = 150)]
        public DateTime EndDate { get; set; }



        public virtual List<MissionOrder> MissionOrders { get; set; }
        [NotMapped]
        public string Name
        {
            get
            {
                if (Theme != null && StartDate != null)
                    return Theme + " - " + StartDate.ToShortDateString();
                else
                {
                    return "";
                }

            }
        }
    }
}
