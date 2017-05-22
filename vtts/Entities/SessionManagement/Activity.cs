// File:    Activite.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:37:55
// Purpose: Definition of Class Activite

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace vtts.Entities.SessionManagement
{
    [GwinEntity(Localizable =true ,isMaleName =false,DisplayMember = "Goal")]
    [Menu(Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title")]
    public class Activity : BaseEntity
    {
 
        public Activity()
        {
            Goal = new LocalizedString();
            Description = new LocalizedString();
        }

        [EntryForm (WidthControl =200,MultiLine=true ,NumberLine =2,Ordre =1)]
        [DataGrid(WidthColonne =150,Ordre =1)]
        [Filter(Ordre =1,WidthControl =150)]
        public LocalizedString Goal { set; get; }


        [EntryForm(WidthControl = 100,Ordre = 4)]
        [DataGrid(WidthColonne = 100, Ordre = 4)]
        [Filter(Ordre = 1, WidthControl = 150)]
        public int Duration { set; get; }


        [EntryForm(WidthControl = 150, Ordre = 2)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(Ordre = 2, WidthControl = 150,isValeurFiltreVide =true )]
        [Relationship(Relation= RelationshipAttribute.Relations.ManyToOne)]
        public  ActivityCategory ActivityCategory { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 3)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(Ordre = 3, WidthControl = 150, isValeurFiltreVide = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  PedagogyStrategy PedagogyStrategy { set; get; }

        [EntryForm(WidthControl = 200, MultiLine = true, NumberLine = 5, Ordre = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 5)]
        [Filter(Ordre = 4, WidthControl = 150)]
        public LocalizedString Description { set; get; }


 
    }
}