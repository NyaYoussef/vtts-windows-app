using App.Formations;
using App.GestionStagiaires;
using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace App.Modules
{
    [AffichageDansFormGestion(Titre = "Gestion des modules", TitrePageGridView = "Modules",
        TitreButtonAjouter = "Ajouter un module")]
    [AffichageClasse(Minuscule = "Module", Majuscule = "Modules", DisplayMember = "Nom")]
    [SelectionCriteria(new Type[] { typeof(Filiere) })]
    public class Module : BaseEntity
    {
        public override string ToString() => this.Nom;

        // 
        // Informations générale
        //
        [AffichagePropriete(Titre = "Nom du module",GroupeBox = "Informations générale",
            isGridView = true, 
            isFormulaire = true,
            isOblegatoir = true,
            Ordre = 1)]
        public String Nom { set; get; }


        [AffichagePropriete(Titre = "Compétence à développé", GroupeBox = "Informations générale",
           isFormulaire = true, MultiLine =true,NombreLigne =5, isOblegatoir = true, Ordre = 2)]
        public string Competence { set; get; }



        [AffichagePropriete(Titre = "Code", GroupeBox = "Informations générale",
            isFormulaire = true, WidthControl = 50, isOblegatoir = true, Ordre = 2,
             isGridView = true, WidthColonne = 50)]
        public String Code { set; get; }



        [AffichagePropriete(Titre = "Présentation", GroupeBox = "Informations générale",
          isFormulaire = true, Ordre = 5, MultiLine = true, NombreLigne = 5
            )]
        public string Presentation { set; get; }

        // 
        // Description pédagogique
        //
        [AffichagePropriete(Titre = "Stratégie d'enseignement", GroupeBox = "Description pédagogique",
         isFormulaire = true, Ordre = 5, MultiLine = true, NombreLigne = 5)]
        public string StrategieEnseignement { set; get; }

        [AffichagePropriete(Titre = "Apprentisage", GroupeBox = "Description pédagogique",
         isFormulaire = true, Ordre = 5, MultiLine = true, NombreLigne = 5)]
        public string Apprentisage { set; get; }

        [AffichagePropriete(Titre = "Evaluation", GroupeBox = "Description pédagogique",
         isFormulaire = true, Ordre = 5, MultiLine = true, NombreLigne = 5)]
        public string Evaluation { set; get; }

        // 
        // Planning
        //

        /// <summary>
        /// La duré en Nombre d'heure
        /// </summary>
        [AffichagePropriete(Titre = "Durée en Heure", GroupeBox = "Planning",
            isGridView = true, isFormulaire = true,
          Unite = "h", isOblegatoir = true, Ordre = 3, WidthColonne = 40)]
        public int Duree { set; get; }



        // 
        // Affectation
        //
        [AffichagePropriete(Titre = "Filiere", GroupeBox = "Affectation",
            isGridView = true, isFormulaire = true,
            isOblegatoir = true, Relation = "ManyToOne", DisplayMember = "Code",
            Filtre = true, WidthColonne = 80, Ordre = 4)]
        public virtual Filiere Filiere { set; get; }
 
       

        // 
        // Description Technique
        //

        [AffichagePropriete(Titre = "Materiél", GroupeBox = "Description Technique",
        isFormulaire = true, Ordre = 5, MultiLine = true, NombreLigne = 5)]
        public string Materiel { set; get; }
        [AffichagePropriete(Titre = "Equipement", GroupeBox = "Description Technique",
        isFormulaire = true, Ordre = 5, MultiLine = true, NombreLigne = 5)]
        public string Equipement { set; get; }
 



        [AffichagePropriete(Titre = "Précisions",
            FilterSelection = true,
             Ordre = 20,
         Relation = "OneToMany", 
            isGridView = true)]
        public virtual List<Precision> Precisions { set; get; }

        public virtual List<PrevisionSeance> PrevisionSeances { set; get; }
        public virtual List<Formation> Formations { set; get; }

        public string Description { set; get; }
    }
}