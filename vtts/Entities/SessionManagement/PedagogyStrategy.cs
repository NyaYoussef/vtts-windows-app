// File:    StrategiePedagogie.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class StrategiePedagogie

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace vtts.Entities.SessionManagement
{
    [GwinEntity(Localizable =true ,isMaleName =false,DisplayMember ="Title")]
    [Menu(Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =700)]
    public class PedagogyStrategy : BaseEntity
   {

        public PedagogyStrategy()
        {
            Title = new LocalizedString();
            Description = new LocalizedString();
        }
        [EntryForm(WidthControl =200,Ordre =0,isRequired =true )]
        [DataGrid(WidthColonne= 150,Ordre =0)]
        [Filter(Ordre =0,WidthControl =150)]
        public LocalizedString Title { set; get; }

        [EntryForm(WidthControl = 250, Ordre = 1,MultiLine =true,NumberLine =5)]
        [DataGrid(WidthColonne = 200, Ordre = 1)]
        [Filter(Ordre = 1, WidthControl = 200)]
        public LocalizedString Description { set; get; }

    }
}