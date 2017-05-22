// File:    CategogiesSalleFormation.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class CategogiesSalleFormation

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;

namespace vtts.Entities.InstitutionManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(TitrePageGridView = "grid_title",Width =750)]
    public class CategogiesClassroom : BaseEntity
   {
        public CategogiesClassroom()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
        [EntryForm(Ordre=1,WidthControl =250,isRequired =true)]
        [DataGrid(Ordre =1,WidthColonne =150)]
        [Filter(Ordre =1,WidthControl =150)]
        public LocalizedString Name { set; get; }

        [EntryForm(Ordre = 0, WidthControl = 100)]
        [DataGrid(Ordre = 0, WidthColonne = 100)]
        [Filter(Ordre = 0, WidthControl = 100)]
        public String Code { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 250,MultiLine =true,NumberLine =5)]
        [DataGrid(Ordre = 2, WidthColonne = 150)]
        [Filter(Ordre = 2, WidthControl = 150)]
        public LocalizedString Description { set; get; }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public List<Classroom> Classrooms { get; set; }

    }
}