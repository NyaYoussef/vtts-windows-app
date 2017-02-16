﻿using App.WinForm.Attributes;
using App.WinForm.Entities;
using Entities.SessionManagement;
using Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Entities.TraineeManagement
{

    [DisplayEntity(Localizable =true,DisplayMember = "Name")]
    [SelectionCriteria(typeof(Specialty))]
    [Menu(Group="Stagiaire")]
    public class Group : BaseEntity
    {
        
        [DisplayProperty(isInGlossary =true)]
        [EntryForm(Ordre = 2)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public string Name { set; get; }

       
        [DisplayProperty(DisplayMember = "Titre")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 2)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public virtual TrainingYear TrainingYears { set; get; }

       
        [DisplayProperty(DisplayMember ="Code")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 3)]
        [Filter(isValeurFiltreVide =true)]
        [DataGrid(WidthColonne = 100)]
        public virtual Specialty Specialty { set; get; }

    }
}
