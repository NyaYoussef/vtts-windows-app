using App.Modules;
using App.WinForm.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace App.GestionStagiaires
{
    [AffichageDansFormGestion(Titre = "Gestion des filieres",
TitrePageGridView = "Filiere",
TitreButtonAjouter = "Ajouter un filiere")]
    [AffichageClasse(Minuscule = "Filière", Majuscule = "Filières" , DisplayMember ="Code")]
    public class Filiere : BaseEntity 
   {

     [AffichagePropriete(Titre = "Titre", 
            isGridView = true, 
            isFormulaire = true,

            Ordre = 1, 
            WidthColonne = 150)]
      public String Titre { set; get; }

      [AffichagePropriete(Titre = "Code",
             isGridView = true,
             isFormulaire = true,
             Filtre = true,
             Ordre = 2,
             WidthColonne = 150)]
        public  String Code { set; get; }

     [AffichagePropriete(Titre = "Description",
           isGridView = true,
           isFormulaire = true,
           Ordre = 3,
           WidthColonne = 150)]
        public String Description { set; get; }


        public virtual List<Module> Modules { set; get; }

        public override string ToString()
        {
            return this.Code;
        }
    }
}