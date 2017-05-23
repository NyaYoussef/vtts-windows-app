using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using vtts.Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.InstitutionManagement
{

    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "Configuration",Title ="menu_title",Order = 1)]
 //   [SelectionCriteria(typeof(Region))]
    [ManagementForm(Width =820,TitrePageGridView ="grid_title")]
    public  class Institution:BaseEntity
    {
        public Institution()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
            this.Address = new LocalizedString();
        }
        [EntryForm(Ordre = 1)]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =1,WidthControl =150)]
        public LocalizedString Name { get; set; }

        [EntryForm(Ordre = 2, MultiLine = true, WidthControl = 300)]
        [DataGrid(WidthColonne = 200)]
        [Filter(Ordre =4, WidthControl = 150)]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre = 3,WidthControl =300)]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =3, WidthControl = 150)]
        public LocalizedString Address { set; get; }

        [EntryForm(Ordre = 3,WidthControl =300,Enable =true)]
        [DataGrid(WidthColonne = 100)]
        [Filter(Ordre =2,isDefaultIsEmpty =true, WidthControl = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public virtual Region Region { set; get; }




    }
}
