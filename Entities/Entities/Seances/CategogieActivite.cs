// File:    CategogieActivite.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:41:25
// Purpose: Definition of Class CategogieActivite

using App.WinForm.Annotation;
using System;

namespace App.Formations
{
    [AffichageDansFormGestion(Titre = "Gestion des catégories d'activités", TitrePageGridView = "Liste des catégories d'activité",
        TitreButtonAjouter = "Ajouter une catégorie d'activité")]
    [AffichageClasse(Minuscule = "Catégorie d'activité", Majuscule = "Catégories d'activité")]
    public class CategogieActivite : BaseEntity
    {

        public override string ToString() => this.Nom;

        [AffichagePropriete(Titre = "Nom de la catégorie", isGridView = true, isFormulaire = true,
          Filtre =true,  isOblegatoir = true, Ordre = 1, WidthColonne = 200)]
        public string Nom { set; get; }



        [AffichagePropriete(Titre = "Description", isFormulaire = true,
          MultiLine =true, Ordre = 10)]
        public String Description { set; get; }

    }
}