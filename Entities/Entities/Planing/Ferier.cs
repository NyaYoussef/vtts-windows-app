using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Formations 
{
    [AffichageDansFormGestion(Titre = "Gestion des féries", 
        TitrePageGridView = "Jours Féries",
       siAffichageAvecOrdre = true, orderBy = "DateDebut",
       TitreButtonAjouter = "Ajouter un projet")]
    [AffichageClasse(Minuscule = "Féries", Majuscule = "Férie", DisplayMember = "Titre")]
    public class Ferier : BaseEntity
    {


        public Ferier():base()
        {
            this.DateDebut = DateTime.Now;
            this.DateFin = DateTime.Now;

        }


        [Required ]
        [AffichagePropriete(Titre = "Titre", Ordre = 2,
           WidthColonne = 200,
           isFormulaire = true, isGridView = true)]
        public string Titre { set; get; }

        [Required]
        [AffichagePropriete(Titre = "Début de férie", 
           Ordre = 3,
           WidthColonne = 120,
           isFormulaire = true, isGridView = true)]
        public DateTime DateDebut { set; get; }

        [Required]
        [AffichagePropriete(Titre = "Fin de férie", Ordre = 4,
           WidthColonne = 120,
           isFormulaire = true, isGridView = true)]
        public DateTime DateFin { set; get; }


        [Required]
        [AffichagePropriete(Titre = "Année de formation", Ordre = 20,
            Relation ="ManyToOne",
            Filtre = true,
           WidthColonne = 100,
           isFormulaire = true, isGridView = true)]
        public virtual AnneeFormation AnneeFormation { set; get; }
    }
}
