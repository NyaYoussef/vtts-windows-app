using App.GestionStagiaires;
using App.Modules;
using App.WinForm.Annotation;
using System;

namespace App.Formations
{
    [AffichageDansFormGestion(Titre = "Gestion des formations", TitrePageGridView = "Formations",
     TitreButtonAjouter = "Ajouter une formation")]
    [AffichageClasse(Minuscule = "Formation", Majuscule = "Formations")]
    [SelectionCriteria(new Type[] { typeof(Filiere), typeof(Module) })]
    public class Formation : BaseEntity
   {

        public override string ToString() => this.Code;

        [AffichagePropriete(Titre = "Année formation", isGridView = true, isFormulaire = true,
     Relation = "ManyToOne", Filtre = true, isOblegatoir = true, Ordre = 1, WidthColonne = 150)]
        public virtual AnneeFormation AnneeFormation { set; get; }



        [AffichagePropriete(Titre = "Filière", isGridView = true, isFormulaire = true,
Relation = "ManyToOne", isValeurFiltreVide = true, Filtre = true, isOblegatoir = true, Ordre = 2, WidthColonne = 150)]
        public virtual Filiere Filiere { set; get; }



        [AffichagePropriete(Titre = "Module", isGridView = true, isFormulaire = true,
   Relation = "ManyToOne",  isOblegatoir = true, Ordre = 3, WidthColonne = 150)]
        public virtual Module Module { set; get; }



        [AffichagePropriete(Titre = "Code", isGridView = true, isFormulaire = true,
         isOblegatoir = true, Ordre = 4, WidthColonne = 150)]
        public String Code { set; get; }



        [AffichagePropriete(Titre = "Groupe", isGridView = true, isFormulaire = true,
   Relation = "ManyToOne", isValeurFiltreVide=true, Filtre = true, isOblegatoir = true, Ordre =5, WidthColonne = 150)]
        public Groupe Groupe { set; get; }



        [AffichagePropriete(Titre = "Formateur", isGridView = true, isFormulaire = true,
Relation = "ManyToOne", Filtre = true, isOblegatoir = true, Ordre = 6, WidthColonne = 150)]
        public Formateur Formateur { set; get; }
 
        
   
   }
}