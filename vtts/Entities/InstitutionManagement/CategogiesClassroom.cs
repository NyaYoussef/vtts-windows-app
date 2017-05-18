// File:    CategogiesSalleFormation.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class CategogiesSalleFormation

using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace App.Formations
{
   public class CategogiesClassroom : BaseEntity
   {
        public CategogiesClassroom()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
        public LocalizedString Name { set; get; }
        public String Code { set; get; }
        public LocalizedString Description { set; get; }

    }
}