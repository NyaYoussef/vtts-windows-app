using App.Formations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{

   /* [AffichageDansFormGestion(Titre = "Gestion des modules", TitrePageGridView = "Modules",
        TitreButtonAjouter = "Ajouter un module")]
    [AffichageClasse(Minuscule = "Absence", Majuscule = "Absences", DisplayMember = "NomStagiaire")]
    public class Absence : BaseEntity
    {

        [AffichagePropriete(Titre = "Stagiaire", isGridView = true, isFormulaire = true,
           isOblegatoir = true, Ordre = 1, WidthColonne = 200)]
        public Stagiaire Stagiaire { set; get; }



        [AffichagePropriete(Titre = "Autorisation", isGridView = true, isFormulaire = true,
           isOblegatoir = true, Ordre = 2, WidthColonne = 200)]
        public bool Autorisation { set; get; }


        [AffichagePropriete(Titre = "Autorisation", isFormulaire = true,
           MultiLine =true, Ordre = 2, WidthColonne = 200)]
        public String CauseAbsence { set; get; }


        [AffichagePropriete(Titre = "Autorisation", isGridView = true, isFormulaire = true,
            Filtre = true,Enable = false,
           MultiLine = true, Ordre = 2, WidthColonne = 200)]
        public Seance Seance { set; get; }

        

        [NotMapped]
        public string NomStagiaire
        {
            get
            {
                if (Stagiaire != null)   return Stagiaire.ToString();
                else return String.Empty;
            }

        }
       

        
    }*/
}
