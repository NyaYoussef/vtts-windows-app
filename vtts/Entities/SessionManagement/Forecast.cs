// File:    PrevisionSeance.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:37:55
// Purpose: Definition of Class PrevisionSeance

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using vtts.Entities.InstitutionManagement;
using vtts.Entities.ModuleManagement;
using vtts.Entities.TrainingManagement;

namespace vtts.Entities.SessionManagement
{
    [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
    [Menu (Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =1020,Height =650)]
    public class Forecast : BaseEntity
    {
        public Forecast()
        {
            Title = new LocalizedString();
            Goal = new LocalizedString();
        }

        [EntryForm (WidthControl=150,Ordre =0,isRequired =true ,GroupeBox = "SingularName",GroupeBoxOrder =0)]
        [DataGrid (Ordre =0,WidthColonne =100)]
        [Filter(Ordre =0,WidthControl =150)]
        public LocalizedString Title { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 1,MultiLine =true,NumberLine =2, isRequired = true, GroupeBox = "SingularName", GroupeBoxOrder = 0)]
        [DataGrid(Ordre = 1, WidthColonne = 100)]
        [Filter(Ordre = 1, WidthControl = 150)]
        public LocalizedString Goal { set; get; }

        [EntryForm(WidthControl = 100, Ordre = 5, GroupeBox = "SingularName", GroupeBoxOrder = 0)]
        [DataGrid(Ordre = 5, WidthColonne = 70)]
        [Filter(Ordre = 3, WidthControl = 100)]
        public int Duration { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 3,GroupeBox = "SingularName", GroupeBoxOrder =0)]
        [DataGrid(Ordre = 3, WidthColonne = 150)]
        [Filter(Ordre = 3, WidthControl = 150,isDefaultIsEmpty =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  CategogiesClassroom CategogiesClassroom { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 4, GroupeBox = "Forecastfor", GroupeBoxOrder = 1)]
        [Filter(Ordre = 4, WidthControl = 150, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Module Module { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 5, GroupeBox = "Forecastfor", GroupeBoxOrder = 1)]
        [DataGrid(Ordre = 5, WidthColonne = 150)]
        [Filter(Ordre = 5, WidthControl = 150, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  PrecisionContent PrecisionContent { set; get; }


        [EntryForm(WidthControl = 100, Ordre = 6, GroupeBox = "Forecastfor", GroupeBoxOrder = 1)]
        [DataGrid(Ordre = 6, WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Activity Activitie { set; get; }


       



    }
}