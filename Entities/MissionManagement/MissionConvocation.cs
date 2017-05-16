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


        [EntryForm(Ordre = 2,GroupeBox ="Details")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 8, MultiLine = true, WidthControl = 300,NumberLine =12,GroupeBox = "Details")]
        [DataGrid(WidthColonne = 200)]
        [Filter]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre=1,WidthControl =200,MultiLine =true,GroupeBox = "menu_title")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Staff> Staffs { get; set; }

        [EntryForm(Ordre = 3, WidthControl = 200, MultiLine = true,GroupeBox = "menu_title")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Institution Institution { get; set; }
        //Sujet
        [EntryForm(Ordre = 4, WidthControl = 200, MultiLine = true,GroupeBox = "menu_title")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionSubject MissionSubject { get; set; }

        [EntryForm(Ordre=5,WidthControl =200,GroupeBox = "Details")]
        [DataGrid(Ordre=5,WidthColonne =200)]
        public DateTime StartDate { get; set; }
        [EntryForm(Ordre = 5, WidthControl = 200,GroupeBox = "Details")]
        [DataGrid(Ordre = 5, WidthColonne = 200)]
        public DateTime EndDate { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200, MultiLine = true,GroupeBox = "menu_title")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<MissionOrder> MissionOrders { get; set; }
    } 
}
