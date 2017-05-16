using App.Gwin.Attributes;
using App.Gwin.Entities.MultiLanguage;
using App.Gwin.Entities.Persons;
using Entities.MissionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "HRManagement",Title ="menu_title")]
    [ManagementForm(Width = 1000,Height = 600)]
   
    public class Staff: Person
    {
        public Staff()
        {
            this.FirstName = new LocalizedString();
            this.LastName = new LocalizedString();
         }

        [NotMapped]
        public string Name
        {
            get
            {
                return this.FirstName.Current + " " + this.LastName.Current;
            }
        }

 
        //[DataGrid(WidthColonne = 100)]
        //[EntryForm(Ordre = 2, GroupeBox = "Civil status", GroupeBoxOrder = 100,isRequired = true)]
        //[Filter("FirstName")]
        //public LocalizedString FirstName { get; set; }

        //[DataGrid(WidthColonne = 100)]
        //[EntryForm(Ordre = 1, GroupeBox = "Civil status", GroupeBoxOrder = 100, isRequired = true)]
        //[Filter("LastName")]
        //public LocalizedString LastName { get; set; }

       
        //
        // Recruitment
        //
        [EntryForm(Ordre = 50, GroupeBox = "Recruitment",isRequired =true)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string RegistrationNumber { get; set; }

        [EntryForm(Ordre =50, GroupeBox = "Recruitment",isRequired =true)]
        [DataGrid(WidthColonne = 100)]
        public DateTime DateRecruitment { get; set; }

        //
        // Assignments
        //
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<Affectation> Affectations { get; set; }

        [NotMapped]
        public Affectation CurrentAffectation {

             get {
                if (Affectations != null)
                   return Affectations.OrderByDescending(a => a.DateAffectation).FirstOrDefault();
                else
                return null;

            }
        }

        [EntryForm(Ordre = 2, GroupeBox = "Functions",isRequired =true)]
        [DataGrid(WidthColonne = 100)]
        [Filter(isValeurFiltreVide =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual Function Function { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public List<Car> Cars { get; set; }


        [Relationship(Relation=RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<MissionConvocation> MissionConvocation { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List<MissionOrder> MissionOrders { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public List <Mission> Missions { get; set; }



    }
}
