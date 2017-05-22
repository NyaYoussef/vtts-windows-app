// File:    Salle.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class Salle

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace vtts.Entities.InstitutionManagement
{
    [GwinEntity(Localizable =true ,isMaleName =false,DisplayMember ="Name")]
   [Menu(Group ="InstitutionManagement")]
   [ManagementForm(TitrePageGridView ="grid_title",Width =890)]
    public class Classroom : BaseEntity
   {
        public Classroom()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
       
        [EntryForm (Ordre=1,WidthControl =250,isRequired =true)]
        [Filter(Ordre =1,WidthControl =150)]
        [DataGrid(Ordre =1,WidthColonne =150)]
        public LocalizedString Name { set; get; }


        [EntryForm(Ordre = 0, WidthControl = 200)]
        [Filter(Ordre = 0, WidthControl = 100)]
        [DataGrid(Ordre = 0, WidthColonne = 100)]
        public String Code { set; get; }


        [EntryForm(Ordre = 2, WidthControl = 250)]
        [Filter(Ordre = 2, WidthControl = 150,isDefaultIsEmpty =true)]
        [DataGrid(Ordre = 2, WidthColonne = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  CategogiesClassroom CategogiesClassroom { set; get; }

        [EntryForm(Ordre = 3, WidthControl = 250,MultiLine =true,NumberLine =3)]
        [Filter(Ordre = 3, WidthControl = 150)]
        [DataGrid(Ordre = 3, WidthColonne = 150)]
        public LocalizedString Description { set; get; }



    }
}