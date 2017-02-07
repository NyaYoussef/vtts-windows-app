using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Livres
{
    [AffichageDansFormGestion(Titre = "Gestion des Livre", TitrePageGridView = "Livres",
       TitreButtonAjouter = "Ajouter un livre")]
    [AffichageClasse(Minuscule = "Livre", Majuscule = "Livres", DisplayMember = "Titre")]

    public class Livre : BaseEntity
    {
        public override string ToString() => this.Titre;
         


        [AffichagePropriete(Titre = "Titre", isGridView = true, isFormulaire = true, Ordre = 1, WidthColonne = 100)]
        public string Titre { set; get; }

        [AffichagePropriete(Titre = "Date de sortie", isGridView = true, isFormulaire = true, Ordre =2, WidthColonne = 100)]
        public DateTime DateSortie { set; get; }

        [AffichagePropriete(Titre = "Miason d'edition",Relation ="ManyToOne", isGridView = true, isFormulaire = true, Ordre = 3, WidthColonne = 100)]
        public MaisonEdition MaisonEdition { set; get; }

        public Livre()
        {
            DateSortie = DateTime.Now;

        }

    }
}
