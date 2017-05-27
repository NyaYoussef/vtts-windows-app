using App.Gwin.Attributes;
using App.Gwin.Entities.MultiLanguage;
using App.Gwin.Entities.Persons;
using vtts.Entities.MissionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.AdvancementManagement;
using App;

namespace vtts.Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "Staffs", Title ="menu_title")]
    [ManagementForm(Width = 1250,Height = 700,TitrePageGridView ="grid_title",TitreButtonAjouter ="Add_title")]
   
    public class Staff: Person
    {
        public Staff()
        {
            this.DateOfBirth = new DateTime();
            this.DateRecruitment = new DateTime();
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
        [EntryForm(Ordre = 50, GroupeBox = "Recruitment",isRequired =true,GroupeBoxOrder =12)]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string RegistrationNumber { get; set; }

        [EntryForm(Ordre =50, GroupeBox = "Recruitment",isRequired =true,GroupeBoxOrder =12)]
        [DataGrid(WidthColonne = 160)]
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

        [EntryForm(Ordre = 2, GroupeBox = "Functions",isRequired =true,GroupeBoxOrder =15)]
        [DataGrid(WidthColonne = 100)]
        [Filter(isDefaultIsEmpty =true,WidthControl =150)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual Function Function { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public List<Car> Cars { get; set; }



        public virtual List<MissionConvocation> MissionConvocations { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public virtual List<MissionOrder> MissionOrders { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public virtual List <Mission> Missions { get; set; }

       [NotMapped]
       [EntryForm(Ordre = 3, GroupeBox = "Functions",GroupeBoxOrder =15)]
        //[Filter(isDefaultIsEmpty = true, WidthControl = 150)]
        //[Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
       public  Grade Grade {

            get
                {
                List<AdvancementScale> advscale = new ModelContext().AdvancementScaleS.Where(r => r.Staff.Id == this.Id).OrderByDescending(r => r.Date).ToList();
                if (advscale.Count > 0)
                    return advscale[0].Scale.Grade;
                else
                    return null;
            }
           set
                { }
        }

        [NotMapped]
        [EntryForm(Ordre = 4, GroupeBox = "Functions", GroupeBoxOrder = 15)]
        public Scale Scales
        {
            get
            {
                List<AdvancementScale> advscale = new ModelContext().AdvancementScaleS.Where(r => r.Staff.Id == this.Id).OrderByDescending(r => r.Date).ToList();
                if (advscale.Count > 0)
                    return advscale[0].Scale;
                else
                return null;

            }
            set { }
        }

        [NotMapped]
        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public  Echelon Echelon { 
            get {
                List<AdvancementEchelon> advEchelon = new ModelContext().AdvancementEchelons.Where(r => r.Staff.Id == this.Id).OrderByDescending(r => r.Date).ToList();
                if (advEchelon.Count > 0)
                    return advEchelon[0].Echelon;
                else
                    return null;
                }
            set { }
            }


        [NotMapped]
        public virtual AdvancementScale AdvancementScale
        {
            get {
                if (Scales != null)
                    return AdvancementScale;

                else
                return new AdvancementScale();


            }
           
        }



    }
}
