// File:    PrevisionSeance.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:37:55
// Purpose: Definition of Class PrevisionSeance

using App.Formations;
using App.GestionStagiaires;
using App.Modules;
using App.WinForm.Annotation;
using System;
using System.Collections.Generic;

namespace App.Formations
{
    [AffichageDansFormGestion(Titre = "Gestion des prévisions des séances", TitrePageGridView = "Prévisions d'une séance",
      TitreButtonAjouter = "Ajouter une prévision d'une séance")]
    [AffichageClasse(Minuscule = "Prévision d'une séance", Majuscule = "Prévisions des séances")]
    [SelectionCriteria(new Type[] { typeof(Filiere) ,typeof(Module)})]
    public class PrevisionSeance : BaseEntity
    {
        public override string ToString() => this.Titre;



        // 
        // Objectif pédagogie
        //
        [AffichagePropriete(Titre = "Titre", GroupeBox = "Objectif pédagogie",
           isGridView = true, isFormulaire = true,
           Filtre = true, isOblegatoir = true, Ordre = 2, WidthColonne = 200)]
        public String Titre { set; get; }



        [AffichagePropriete(Titre = "Objectif", GroupeBox = "Objectif pédagogie",
            isFormulaire = true,NombreLigne = 10,
             MultiLine = true, Filtre = true, isOblegatoir = true, Ordre = 3, WidthColonne = 150)]
        public String Objectif { set; get; }


        [AffichagePropriete(Titre = "Durée", GroupeBox = "Objectif pédagogie",
            isGridView = true, isFormulaire = true,
          Unite = "min", isOblegatoir = true, Ordre = 4, WidthColonne = 40)]
        public int Duree { set; get; }


        [AffichagePropriete(Titre = "Catégogie salle", GroupeBox = "Objectif pédagogie",
            isGridView = true, isFormulaire = true,
         Relation = "ManyToOne", isOblegatoir = true, Ordre = 5, WidthColonne = 70)]
        public virtual CategogiesSalleFormation categogiesSalleFormation { set; get; }

        // 
        // Affectation
        //
        [AffichagePropriete(Titre = "Module", GroupeBox = "Module",
            isGridView = true, isFormulaire = true,
         Relation = "ManyToOne", FilterSelection = true, 
            Filtre = true, isOblegatoir = true, Ordre = 11, WidthColonne = 120)]

        public virtual Module Module { set; get; }

        //
        // Objectf pédagogie et Contenue
        //
        [AffichagePropriete(Titre = "Contenue", GroupeBox = "Objectf pédagogie",
        Relation = "ManyToMany", TabPage = false,
            isFormulaire = true , Ordre = 20,
            isGridView = true)]
        [SelectionCriteria(new Type[] { typeof(Filiere), typeof(Module),typeof(Precision) })]
        public virtual List<ContenuePrecision> contenuePrecision { set; get; }

        //[AffichagePropriete(Titre = "Activités",
        //Relation = "ManyToMany", TabPage = false,
        //    isGridView = true,isFormulaire =true, Ordre = 21)]
        public virtual List<Activite> Activites { set; get; }


       



    }
}