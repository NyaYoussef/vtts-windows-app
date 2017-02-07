// File:    StrategiePedagogie.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class StrategiePedagogie

using App.WinForm.Annotation;
using System;

namespace App.Formations
{
    [AffichageDansFormGestion(Titre = "Gestion des stratégies pédagogique", TitrePageGridView = "Stratégie pédagogique",
    TitreButtonAjouter = "Ajouter une stratégie pédagogique")]
    [AffichageClasse(Minuscule = "Stratégie pédagogique", Majuscule = "Stratégies pédagogique")]
    public class StrategiePedagogie : BaseEntity
   {

        public override string ToString() => this.Titre;


        [AffichagePropriete(Titre = "Nom de la stratégie", isGridView = true, isFormulaire = true,
             isOblegatoir = true, Ordre = 1, WidthColonne = 200)]


        public String Titre { set; get; }
        [AffichagePropriete(Titre = "Description", isGridView = true, isFormulaire = true,
          MultiLine =true,  Ordre = 2, WidthColonne = 400)]
        public String Description { set; get; }

    }
}