// File:    Salle.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class Salle

using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace App.Formations
{
   
    public class Classroom : BaseEntity
   {
        public Classroom()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
       
        public LocalizedString Name { set; get; }


       
        public String Code { set; get; }
       

       
        public virtual CategogiesClassroom CategogiesClassroom { set; get; }

      
        public LocalizedString Description { set; get; }



    }
}