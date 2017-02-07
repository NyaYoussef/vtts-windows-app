using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GestionProjets
{
    [AffichageDansFormGestion(Titre = "Gestion des projets", TitrePageGridView = "Projets",
        TitreButtonAjouter = "Ajouter un projet")]
    [AffichageClasse(Minuscule = "Projet", Majuscule = "Projets", DisplayMember = "Titre")]
    [ApplicationMenu()]
    public class Projet  :BaseEntity
    {

        [Required]
        [AffichagePropriete(Titre = "Titre", Ordre = 1,
            WidthColonne = 200,
            isFormulaire =true,isGridView =true)]
        public string Titre { set; get; }



        [AffichagePropriete(Titre = "Description", Ordre =3,
            MultiLine = true,
            WidthColonne = 200,
            isFormulaire = true, isGridView = true)]
        public string Description { set; get; }


        [AffichagePropriete(Titre = "Tâches",
           
        Relation = "ManyToMany", isGridView = true, Ordre = 20)]
        public virtual List<Tache> Taches { set; get; }

        public override string ToString()
        {
            return Titre;
        }

    }

   
}
