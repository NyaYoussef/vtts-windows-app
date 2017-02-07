using App.GestionStagiaires;
using App.WinForm.Annotation;
using System;
using System.Collections.Generic;

namespace App.Modules
{
    [AffichageDansFormGestion(Titre = "Gestion des précision", siAffichageAvecOrdre = true,
       TitrePageGridView = "Précision",
       TitreButtonAjouter = "Ajouter une précision")]
    [AffichageClasse(Minuscule = "Précision", Majuscule = "Précisions", DisplayMember = "Nom")]
    public class Precision : BaseEntity
   {
        public override string ToString() => this.Nom;

        //
        // Nom
        //
        [AffichagePropriete(Titre = "Précision", isGridView = true, isFormulaire = true, Ordre = 2, 
           isOblegatoir =true, WidthColonne = 200)]
        public string Nom { set; get; }

        //
        // Duree
        //
        [AffichagePropriete(Titre = "Durée", isGridView = true, isFormulaire = true, Ordre = 3,
           
            WidthColonne = 50)]
        public int Duree { set; get; }

        [AffichagePropriete(Titre = "Description", isFormulaire = true, Ordre = 4,MultiLine = true)]
        public string Description { set; get; }
       
        //
        // Module
        //
        [AffichagePropriete(Titre = "Module",
            Relation = "ManyToOne",
            Filtre = true,
            isGridView = true, 
            isFormulaire = true, isOblegatoir = true, Ordre = 5, 
            WidthColonne = 150)]
        public virtual Module Module { set; get; }


        [AffichagePropriete(Titre = "Préalables",
         isGridView = true, Ordre = 21)]
        public virtual List<Prealable> Prealables { set; get; }

        [AffichagePropriete(Titre = "Contenues", WidthColonne = 120,
         isGridView = true, Ordre = 20)]
        public virtual List<ContenuePrecision> ContenuePrecisions { set; get; }



    }
}