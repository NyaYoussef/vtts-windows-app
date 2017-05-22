using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using vtts.Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "MissionManagement",Order =3,Title = "menu_title")]
    [ManagementForm(Width =790,TitrePageGridView ="grid_title")]
    public class Mission:BaseEntity
    {
        public Mission()
        {
            this.Name = new LocalizedString();
        }
        [DataGrid(Ordre=1,WidthColonne =150)]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter(Ordre = 1,WidthControl =150)]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre =1,WidthControl =300)]
        [DataGrid(Ordre = 2, WidthColonne = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =2,isDefaultIsEmpty =true,WidthControl =150)]
        public ThemeCategory ThemeCategory { get; set; }

        [DataGrid(Ordre = 3, WidthColonne = 150)]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Staff> Staffs { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =4,isDefaultIsEmpty =true,WidthControl =150)]
        public MissionOrder MissionOrder { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =5,isDefaultIsEmpty =true,WidthControl =150)]
        public MissionCategory MissionCategory { get; set; }

    }
}
