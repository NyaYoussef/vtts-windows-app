using App.Formations;
using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace App.GestionStagiaires
{
    [AffichageDansFormGestion(Titre = "Gestion des groupes", TitrePageGridView = "Groupes",
        TitreButtonAjouter = "Ajouter un groupe")]
    [AffichageClasse(Minuscule = "Groupe", Majuscule = "Groupes")]
    public class Groupe : BaseEntity
    {
        [AffichagePropriete( Titre = "Nom", 
            isGridView = true, isFormulaire = true, Ordre = 2,
            Filtre = true,
            WidthColonne = 150)]
        public string Nom { set; get; }

        [AffichagePropriete(Titre = "Année de formation",
          isGridView = true,
          isFormulaire = true,
          Relation = "ManyToOne",
          DisplayMember = "Titre",
          Filtre = true,
          WidthColonne = 150,
          Ordre = 1)]
        public virtual AnneeFormation AnneeFormation { set; get; }

        [AffichagePropriete(Titre = "Filiere", 
           isGridView = true,
           isFormulaire = true,
           Relation = "ManyToOne",
           DisplayMember = "Code",
           Filtre = true,
            isValeurFiltreVide = true,
           WidthColonne = 100,
           Ordre = 3)]
        public virtual Filiere Filiere { set; get; }

   
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
