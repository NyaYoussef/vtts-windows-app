// File:    Salle.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class Salle

using App.WinForm.Annotation;
using System;

namespace App.Formations
{
    [AffichageDansFormGestion(Titre = "Gestion des salles", TitrePageGridView = "Salles",
    TitreButtonAjouter = "Ajouter une salle")]
    [AffichageClasse(Minuscule = "Salle", Majuscule = "Salles")]
    public class Salle : BaseEntity
   {

        public override string ToString() => this.Nom;


        [AffichagePropriete(Titre = "Nom", isGridView = true, isFormulaire = true,
        Filtre = true, isOblegatoir = true, Ordre = 1, WidthColonne = 150)]
        public String Nom { set; get; }


        [AffichagePropriete(Titre = "Code", isGridView = true, isFormulaire = true,
        Filtre = true, isOblegatoir = true, Ordre = 2, WidthColonne = 80)]
        public String Code { set; get; }
       

        [AffichagePropriete(Titre = "Catégogie Salle", isGridView = true, isFormulaire = true,
       Relation = "ManyToOne", Filtre = true, isOblegatoir = true, Ordre = 3, WidthColonne = 100)]
        public virtual CategogiesSalleFormation CategogiesSalleFormation { set; get; }

        [AffichagePropriete(Titre = "Code", isFormulaire = true,
        Ordre = 10,MultiLine =true)]
        public String Description { set; get; }



    }
}