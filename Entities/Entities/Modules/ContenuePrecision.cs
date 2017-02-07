using App.GestionStagiaires;
using App.WinForm.Annotation;
using System;
namespace App.Modules
{
    [AffichageDansFormGestion(Titre = "Gestion des contenues de precision", TitrePageGridView = "Contenues de precision",
     TitreButtonAjouter = "Ajouter un contenue de precision")]
    [AffichageClasse(Minuscule = "Contenue de precision", Majuscule = "Contenues de precision", DisplayMember = "Objectif")]
    [SelectionCriteria(new Type[] { typeof(Filiere), typeof(Module), typeof(Precision) })]
    public class ContenuePrecision :BaseEntity
   {

        public override string ToString() => this.Objectif;


        [AffichagePropriete(Titre = "Précision", isGridView = true, isFormulaire = true,
  Relation = "ManyToOne", Filtre = true, isOblegatoir = true, Ordre = 1, WidthColonne = 100)]
        public virtual Precision Precision { set; get; }


        [AffichagePropriete(Titre = "Objectif", isGridView = true, isFormulaire = true,
           Filtre =true, isOblegatoir = true, Ordre = 2, WidthColonne = 200)]
        public  string Objectif { set; get; }


        [AffichagePropriete(Titre = "Durée en minute", isGridView = true, isFormulaire = true,
  Unite = "min", isOblegatoir = true, Ordre = 3, WidthColonne = 80)]
        public int Duree { set; get; }



        [AffichagePropriete(Titre = "Description", isFormulaire = true,
      MultiLine = true, Ordre = 10)]
        public string Description { set; get; }

    }
}