// File:    Sequences.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 17:00:13
// Purpose: Definition of Class Sequences

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using vtts.Entities.ModuleManagement;

namespace vtts.Entities.SessionManagement
{
    [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
    [Menu(Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title")]
    public class Sequence:BaseEntity
   {
        public Sequence()
        {
            Title = new LocalizedString();
            Goal = new LocalizedString();
        }
        [EntryForm (WidthControl =150,Ordre =0,isRequired =true )]
        [DataGrid(WidthColonne =150,Ordre =0)]
        [Filter(Ordre =0,WidthControl=150)]
      public  LocalizedString Title { get; set; }

        [EntryForm(WidthControl = 150, Ordre = 1,MultiLine =true,NumberLine =2, isRequired = true)]
        [DataGrid(WidthColonne = 150, Ordre = 1)]
        [Filter(Ordre = 1, WidthControl = 150)]
        public  LocalizedString Goal { get; set; }

        [EntryForm(WidthControl = 150, Ordre = 2, MultiLine = true, NumberLine = 2, isRequired = true)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(Ordre = 2, WidthControl = 150)]
        public  LocalizedString TargetedSkills { get; set; }

        [EntryForm(WidthControl = 150, Ordre = 3, MultiLine = true, NumberLine = 2, isRequired = true)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(Ordre = 3, WidthControl = 150)]
        private LocalizedString TransversalSkills { get; set; }

        [EntryForm(WidthControl = 150, Ordre = 4, isRequired = true)]
        [DataGrid(WidthColonne = 150, Ordre = 4)]
        [Filter(Ordre = 4, WidthControl = 150,isValeurFiltreVide =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public virtual  List< Precision> Precisions { get; set; }
      
    
     
   }
}