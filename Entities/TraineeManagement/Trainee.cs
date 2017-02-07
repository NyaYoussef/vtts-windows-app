using App.WinForm.Attributes;
using App.WinForm.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace App.GestionStagiaires
{
    [DisplayEntity(Localizable =true,isMaleName =true,DisplayMember ="Name")]
    [Menu]
    public class Trainne : Person {
 
        public int State { set; get; }

        // Affectation
        [AffichagePropriete(Titre = "Groupe", isGridView = true, isFormulaire = true,
    Relation = "ManyToOne",
    DisplayMember = "Nom",
    Filtre = true,
    WidthColonne = 100,
    Ordre = 3)]
        public virtual Groupe Groupe { set; get; }
        public virtual List<MiniGroupe> MiniGroupes { set; get; }

        [AffichagePropriete(Titre = "Filiere", isGridView = true, isFormulaire = true,
        Relation = "ManyToOne",
        DisplayMember = "Code",
        Filtre = true,
        WidthColonne = 100,
        Ordre = 3)]
        public virtual Filiere Filiere { set; get; }


        // Gestion des tâches
        // un stagiaire peut avoir plusieurs tâches
        public virtual List<Tache> Taches { set; get; }


        public Stagiaire() : base()
        {
            this.DateNaissance = DateTime.Now;
        }

     
        public override string ToString()
        {
            return this.Nom + "," + this.Prenom ;
        }
    }
}
  
