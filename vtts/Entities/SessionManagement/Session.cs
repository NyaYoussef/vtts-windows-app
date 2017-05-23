// File:    Seance.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:56:52
// Purpose: Definition of Class Seance

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using vtts.Entities.InstitutionManagement;

namespace vtts.Entities.SessionManagement
{
  [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
  [Menu(Group ="SessionManagement")]
  [ManagementForm(TitrePageGridView ="grid_title",Width =1035,Height =650)]
    public class Session : BaseEntity
   {
        [EntryForm (WidthControl =150,Ordre =3,GroupeBox = "SingularName",GroupeBoxOrder =0)]
        [DataGrid(WidthColonne =150,Ordre =3)]
        [Filter(WidthControl =150,Ordre =3,isDefaultIsEmpty =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
       public  Forecast Forecast { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 4, GroupeBox = "SingularName", GroupeBoxOrder = 0)]
        [DataGrid(WidthColonne = 100, Ordre = 4)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Training Training { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 4,GroupeBox ="Date",GroupeBoxOrder =1)]
        [DataGrid(WidthColonne = 100, Ordre = 4)]
        [Filter(WidthControl = 150, Ordre = 4,isDefaultIsEmpty =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Classroom Classroom { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 5, GroupeBox = "Date", GroupeBoxOrder = 1)]
        [DataGrid(WidthColonne = 150, Ordre = 5)]
        public DateTime RealisationDate { set; get; }

        [EntryForm(WidthControl = 100, Ordre = 6, GroupeBox = "Date", GroupeBoxOrder = 1)]
        public int StartingHour { set; get; }

        [EntryForm(WidthControl = 100, Ordre = 7, GroupeBox = "Date", GroupeBoxOrder = 1)]
        public int EndingHour { set; get; }

        [EntryForm(WidthControl = 100, Ordre = 8, GroupeBox = "Date", GroupeBoxOrder = 1)]
        [Filter(Ordre =4,WidthControl =150)]
        public int Duration { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 0,isRequired =true, GroupeBox = "SingularName", GroupeBoxOrder = 0)]
        [DataGrid(WidthColonne = 100, Ordre = 0)]
        [Filter(WidthControl = 150, Ordre = 0)]
        public LocalizedString Title { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 1,MultiLine =true,NumberLine =3, GroupeBox = "SingularName", GroupeBoxOrder = 0)]
        [DataGrid(WidthColonne = 100, Ordre = 1)]
        public LocalizedString Goal { set; get; }

        public Session()
        {
            Title = new LocalizedString();
            Goal = new LocalizedString();
        }

        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public  List<Absence> Absences { set; get; }


        [Filter(WidthControl = 150, Ordre = 3, isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public List <Activity> Activities { set; get; }



    }
}