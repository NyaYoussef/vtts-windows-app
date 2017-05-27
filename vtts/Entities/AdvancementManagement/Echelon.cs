using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.StaffManagement;

namespace vtts.Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "AdvanceManagement", Title = "menu_title")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =750,Height =650)]
    public class Echelon:BaseEntity
    {
        public Echelon()
        {
            this.Description = new LocalizedString();
        }
    
        [EntryForm(Ordre = 0, GroupeBox = "Echelons", WidthControl = 200)]
        [DataGrid(WidthColonne = 150,Ordre =0)]
        [Filter(Ordre = 1, isDefaultIsEmpty = true, WidthControl = 200)]
        public int Numbre { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "Echelons",MultiLine =true,WidthControl =200)]
        [DataGrid(WidthColonne = 200)]
        [Filter(Ordre =1,isDefaultIsEmpty =true,WidthControl =200)]
        public LocalizedString Description { get; set; }

       /* [EntryForm(Ordre = 3, GroupeBox = "Echlon", WidthControl = 300)]
        [DataGrid(WidthColonne = 100)]*/
        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public List<AdvancementEchelon> AdvancementEchelons { set; get; }

        [Relationship(Relation =RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Staff> Staffs { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Description != null)
                    return Description.Current;
                else
                {
                    return "";
                }

            }
        }

    }
}
