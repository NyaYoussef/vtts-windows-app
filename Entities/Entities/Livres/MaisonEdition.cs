using App.WinForm.Annotation;

namespace App.Livres
{
    [AffichageDansFormGestion(Titre = "Gestion des maisons d'éditions",
     TitrePageGridView = "Maisons d'éditions",
    TitreButtonAjouter = "Ajouter une maison d'édition")]
    [AffichageClasse(Minuscule = "Maison d'édition", Majuscule = "Maison d'éditions", DisplayMember = "Nom")]
    public class MaisonEdition : BaseEntity

    {
       

        public override string ToString() => this.Nom;

        [AffichagePropriete(Titre = "Nom", isGridView = true, isFormulaire = true, Ordre = 1, WidthColonne = 100)]
        public string Nom { set; get; }
        [AffichagePropriete(Titre = "Adresse", isFormulaire = true, Ordre = 1,MultiLine =true)]
        public string Adresse { set; get; }
    }
}