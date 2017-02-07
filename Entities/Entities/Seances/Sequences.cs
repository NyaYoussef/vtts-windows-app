// File:    Sequences.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 17:00:13
// Purpose: Definition of Class Sequences

using App.Modules;
using System;

namespace App.Formations
{
   public class Sequence
   {
      private int id;
      private String titre;
      private String objectif;
      private String competencesVises;
      private String competencesTransversales;
      
      public Modules.Precision[] precision;
      
      /// <summary>
      /// Property for collection of Modules.Precision
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public Precision[] Precision
      {
         get
         {
            return precision;
         }
         set
         {
            precision = value;
         }
      }
   
   }
}