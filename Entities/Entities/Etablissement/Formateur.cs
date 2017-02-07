using App.GestionStagiaires;
using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Formations
{
    [AffichageDansFormGestion(Titre = "Gestion des Formateurs",
TitrePageGridView = "Formateurs",
TitreButtonAjouter = "Ajouter un formateur")]
    [AffichageClasse(Minuscule = "Formateur", Majuscule = "Formateur",DisplayMember ="Nom")]
    public class Formateur: Utilisateur
    {
        public override string ToString() => base.ToString();

        [AffichagePropriete(Titre = "Spécialité",Relation ="ManyToOne", isGridView = true, isFormulaire = true, Ordre = 1, WidthColonne = 150)]
        public virtual Filiere Filiere { set; get; }
 
    }
}
