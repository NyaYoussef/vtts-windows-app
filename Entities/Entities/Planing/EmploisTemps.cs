// File:    EmploisTemps.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:53:52
// Purpose: Definition of Class EmploisTemps

using System;

namespace App.Formations
{
   public class EmploisTemps
   {
      private int id;
      private DateTime dateDebut;
      private DateTime dateFin;
      
      public System.Collections.Generic.List<SeancePlanning> seancePlanning;
      
      /// <summary>
      /// Property for collection of SeancePlanning
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
     
      public Formateur formateur;
      
      /// <summary>
      /// Property for Formateurs.Formateur
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Formateur Formateur
      {
         get
         {
            return formateur;
         }
         set
         {
            this.formateur = value;
         }
      }
      public AnneeFormation anneeFormation;
      
      /// <summary>
      /// Property for AnneeFormations.AnneeFormation
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public AnneeFormation AnneeFormation
      {
         get
         {
            return anneeFormation;
         }
         set
         {
            this.anneeFormation = value;
         }
      }
   
   }
}