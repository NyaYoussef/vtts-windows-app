using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.TrainingManagement
{
    public class Module : BaseEntity
    {
        public override string ToString() => this.Name;

        // 
        // Informations générale
        //
       
        public String Name { set; get; }


        public string Competence { set; get; }



        public String Code { set; get; }



      
        public string Presentation { set; get; }

        // 
        // Description pédagogique
        //

        public string TeachingStrategy { set; get; }

        public string Learning { set; get; }

        public string Evaluation { set; get; }

        // 
        // Planning
        //
        /// <summary>
        /// La duré en Nombre d'heure
        /// </summary>
        public int Duration { set; get; }
        // 
        // Affectation
        //
       
     //   public virtual Filiere Filiere { set; get; }
 
        // 
        // Description Technique
        //  
        public string Equipement { set; get; }
       
        //public virtual List<Precision> Precisions { set; get; }

        //public virtual List<PrevisionSeance> PrevisionSeances { set; get; }
        //public virtual List<Formation> Formations { set; get; }

        public string Description { set; get; }
    }
}