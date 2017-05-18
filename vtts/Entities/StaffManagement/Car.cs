using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "Staffs")]
    [ManagementForm(TitrePageGridView ="grid_title")]
    public class Car: BaseEntity
    {
        [EntryForm(Ordre=1,WidthControl =350)]
        [DataGrid(WidthColonne =130)]
        [Filter]
        public string Mark { set; get; }

        [EntryForm(Ordre = 1,WidthControl =350)]
        [DataGrid(WidthColonne = 150)]
        [Filter]
        public string PlateNumber { set; get; }

        [EntryForm(Ordre = 1,WidthControl =350)]
        
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Staff Staff { get; set; }

        /// <summary>
        /// Determine if Car is Private or Personel
        /// </summary>
        [EntryForm(Ordre = 1)]
        [DataGrid(WidthColonne = 150)]
        public bool PersonelCar { get; set; }

        [EntryForm(Ordre = 1,WidthControl =100)]
        [DataGrid(WidthColonne = 150)]
        public float TaxPower { get; set; }


        [NotMapped]
        public string Name
        {
            get
            {
                if (Mark != null && PlateNumber != null)
                    return Mark + " : " + PlateNumber;
                else
                {
                    return "";
                }

            }
        }
    }
}
