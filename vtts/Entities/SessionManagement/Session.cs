// File:    Seance.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:56:52
// Purpose: Definition of Class Seance

using App.Formations;
using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;

namespace vtts.Entities.SessionManagement
{
  [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
  [Menu(Group ="SessionManagement")]
  [ManagementForm(TitrePageGridView ="grid_title")]
    public class Session : BaseEntity
   {
        [EntryForm (WidthControl =150,Ordre =3)]
        [DataGrid(WidthColonne =150,Ordre =3)]
        [Filter(WidthControl =150,Ordre =3,isValeurFiltreVide =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
       public  Forecast Forecast { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 4)]
        [DataGrid(WidthColonne = 150, Ordre = 4)]
        [Filter(WidthControl = 150, Ordre = 4,isValeurFiltreVide =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public  Training Training { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 4)]
        [DataGrid(WidthColonne = 150, Ordre = 4)]
        [Filter(WidthControl = 150, Ordre = 4,isValeurFiltreVide =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Classroom Classroom { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 5)]
        [Filter(WidthControl = 150, Ordre = 5,isValeurFiltreVide =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public DateTime RealisationDate { set; get; }

        [EntryForm(WidthControl = 150, Ordre = 6)]
        public int StartingHour { set; get; }

        [EntryForm(WidthControl = 100, Ordre = 7)]
        public int EndingHour { set; get; }

        [EntryForm(WidthControl = 100, Ordre = 8)]
        [Filter(Ordre =4,WidthControl =150)]
        public int Duration { set; get; }

        [EntryForm(WidthControl = 200, Ordre = 0,isRequired =true)]
        [DataGrid(WidthColonne = 150, Ordre = 0)]
        [Filter(WidthControl = 150, Ordre = 0)]
        public LocalizedString Title { set; get; }

        [EntryForm(WidthControl = 200, Ordre = 1,MultiLine =true,NumberLine =2)]
        [DataGrid(WidthColonne = 150, Ordre = 1)]
        [Filter(WidthControl = 150, Ordre = 1)]
        public LocalizedString Goal { set; get; }

        public Session()
        {
            Title = new LocalizedString();
            Goal = new LocalizedString();
        }

        [EntryForm(WidthControl = 200, Ordre = 2)]
        [Filter(WidthControl = 150, Ordre = 2,isValeurFiltreVide =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public virtual List<Absence> Absences { set; get; }


        [EntryForm(WidthControl = 200, Ordre = 3)]
        [Filter(WidthControl = 150, Ordre = 3, isValeurFiltreVide = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        public virtual List<Activity> Activities { set; get; }



    }
}