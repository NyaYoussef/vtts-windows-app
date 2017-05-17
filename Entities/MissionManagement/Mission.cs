using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "MissionManagement",Order =10)]
    public class Mission:BaseEntity
    {
        public Mission()
        {
            this.Name = new LocalizedString();
        }
        [DataGrid(Ordre=1,WidthColonne =150)]
        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Filter(Ordre = 1)]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre =1,WidthControl =200)]
        [DataGrid(Ordre = 2, WidthColonne = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =2,isValeurFiltreVide =true)]
        public ThemeCategory ThemeCategory { get; set; }

        [DataGrid(Ordre = 3, WidthColonne = 150)]
        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Staff> Staffs { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionOrder MissionOrder { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 200)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MissionCategory MissionCategory { get; set; }

    }
}
