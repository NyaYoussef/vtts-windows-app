using App.WinForm.Attributes;
using App.WinForm.Entities;
using App.WinForm.Entities.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.ProjectsManagement
{
    [DisplayEntity(isMaleName = true, DisplayMember = "Title", Localizable = true)]
    [Menu(Group = "ProjectsToolStripMenuItem", Localizable = true)]
    public class Project  :BaseEntity
    {

        //[Required]
        [DisplayProperty(Titre = "Titre")]
        [EntryForm(Ordre = 1,GroupeBox ="Nom du projet")]
        [DataGrid(WidthColonne = 200)]
        [Filter()]
        public string Title { set; get; }

        [DisplayProperty(Titre = "Description")]
        [EntryForm(Ordre = 3, MultiLine = true, GroupeBox = "Nom du projet")]
        [Filter()]
        [DataGrid(WidthColonne = 200)]
        public string Description { set; get; }


        [DisplayProperty(Titre = "Tâches")]
        [Relationship(Relation = RelationshipAttribute.Relations.OneToMany)]
        [DataGrid()]
        public virtual List<ProjectTask> ProjectTasks { set; get; }

        public override string ToString()
        {
            return Title;
        }

        [DisplayProperty(Titre = "Ressouce")]
        [EntryForm(Ordre = 21, GroupeBox = "Ressouces")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany)]
        public virtual List<RessouceProject> RessouceProjects { set; get; }

    }

   
}
