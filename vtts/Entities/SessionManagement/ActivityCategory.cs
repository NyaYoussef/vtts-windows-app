// File:    CategogieActivite.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:41:25
// Purpose: Definition of Class CategogieActivite

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace vtts.Entities.SessionManagement
{
    [GwinEntity(Localizable =true ,isMaleName =false,DisplayMember ="Name")]
    [Menu (Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =650)]
     public class ActivityCategory : BaseEntity
    {
        public ActivityCategory()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
      
        [EntryForm (WidthControl =200,Ordre =1)]
        [DataGrid(Ordre =0,WidthColonne =150)]
        [Filter(Ordre =0,WidthControl =150)]
        public LocalizedString Name { set; get; }


        [EntryForm(WidthControl = 250,MultiLine =true ,NumberLine =5, Ordre = 2)]
        [DataGrid(Ordre = 1, WidthColonne = 150)]
        [Filter(Ordre = 1, WidthControl = 150)]
        public LocalizedString Description { set; get; }

    }
}