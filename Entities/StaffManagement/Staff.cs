using App.Gwin.Attributes;
using App.Gwin.Entities.Persons;
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
    public class Staff: Person
    {

        //
        // Recruitment
        //
        [EntryForm(Ordre = 50, GroupeBox = "Recruitment")]
        [DataGrid(WidthColonne = 100)]
        [Filter]
        public string RegistrationNumber { get; set; }

        [EntryForm(Ordre =50, GroupeBox = "Recruitment")]
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

        [EntryForm(Ordre = 2, GroupeBox = "Assignments")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Function Function { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public List<Car> Cars { get; set; }

      

    }
}
