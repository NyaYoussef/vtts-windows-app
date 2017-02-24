using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.ProjectsManagement
{
    [ManagementForm (FormTitle="Gestion des tâches",
        TitrePageGridView="Tâches",
        TitreButtonAjouter="Ajouter une tâche")]
    [DisplayEntity( SingularName = "Tâche", PluralName = "Tâches", DisplayMember = "Titre",Localizable =true)]
    public class ProjectTask : BaseEntity 
    {

       

        //[Required]
        [DisplayProperty(Titre = "Titre")]
        [EntryForm(Ordre = 1)]
        [Filter()]
        [DataGrid(WidthColonne = 200)]
        public string Titre { set; get; }


        [DisplayProperty(Titre = "Description")]
        [EntryForm(Ordre = 3, MultiLine = true)]
        [DataGrid(WidthColonne = 200)]
        public string Description { set; get; }

 
        [DisplayProperty( DisplayMember ="Titre", Titre = "Projet" )]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 2, Enable = false)]
        [Filter()]
        [DataGrid()]
        public virtual Project Projet {set;get;}

        public override string ToString()
        {
            if (this.Titre == null) return "null";
            return this.Titre;
        }

    }
}
