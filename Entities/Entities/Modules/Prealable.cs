using App.WinForm.Annotation;
using System;

namespace App.Modules
{

    [AffichageDansFormGestion(Titre = "Gestion des préalables", TitrePageGridView = "Préalables",
        siAffichageAvecOrdre = true,
        TitreButtonAjouter = "Ajouter un préalable")]
    [AffichageClasse(Minuscule = "Préalable", Majuscule = "Préalables")]
    public class Prealable : BaseEntity
   {

        public override string ToString() => this.Nom;


        [AffichagePropriete(Titre = "Précision", isGridView = true, isFormulaire = true,
         Filtre = true, Relation ="ManyToOne",  isOblegatoir = true, Ordre = 2, WidthColonne = 200)]
        public virtual Precision Precision { set; get; }


        [AffichagePropriete(Titre = "Titre", isGridView = true, isFormulaire = true,
            Filtre = true, isOblegatoir = true, Ordre = 3, WidthColonne = 200)]
        public string Nom { set; get; }


        [AffichagePropriete(Titre = "Remarque",
          isFormulaire = true,
          Ordre = 6,
          MultiLine = true)]
        public string Description { set; get; }
       

       

    }
}