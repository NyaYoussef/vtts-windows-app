// File:    Activite.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:37:55
// Purpose: Definition of Class Activite

using App.WinForm.Annotation;
using System;

namespace App.Formations
{
    

    [AffichageDansFormGestion(Titre = "Gestion des Activités", TitrePageGridView = "Activités",
     TitreButtonAjouter = "Ajouter une activité")]
    [AffichageClasse(Minuscule = "Activité", Majuscule = "Activité")]
    public class Activite : BaseEntity
    {
        public override string ToString() => this.Objectif;
         

        [AffichagePropriete(Titre = "Objectif", isGridView = true, isFormulaire = true,
             isOblegatoir = true, Ordre = 1, WidthColonne = 300)]

        public String Objectif { set; get; }
        [AffichagePropriete(Titre = "Durée", isGridView = true, isFormulaire = true,
         Filtre = true, Unite ="min",    isOblegatoir = true, Ordre =2, WidthColonne = 80)]
        public int Duree { set; get; }


        [AffichagePropriete(Titre = "Catégogie d'activite", 
            isGridView = true, isFormulaire = true,
            Relation ="ManyToOne",
           Filtre =true, isOblegatoir = true, Ordre = 3, WidthColonne = 100)]
        public virtual CategogieActivite CategogieActivite { set; get; }



        [AffichagePropriete(Titre = "Stratégie Pédagogie", 
            isGridView = true, isFormulaire = true,
             Relation = "ManyToOne",
            Filtre = true, isOblegatoir = true, Ordre = 4, WidthColonne = 100)]
        public virtual StrategiePedagogie StrategiePedagogie { set; get; }

 
 
        [AffichagePropriete(Titre = "Description", isFormulaire = true,
         MultiLine = true, Ordre = 10)]
        public String Description { set; get; }


 
    }
}