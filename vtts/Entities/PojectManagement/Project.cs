using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.ProjectManagement
    {
     [GwinEntity(Localizable =true ,isMaleName =true ,DisplayMember ="Title")]
     //[Menu(Group ="")]
     [ManagementForm(TitrePageGridView ="grid_title")]
    public class Project  :BaseEntity
    {
        public Project()
        {
            Title = new LocalizedString();
            Description = new LocalizedString();
        }
       
        [EntryForm (WidthControl =200,Ordre =0,isRequired =true,MultiLine =true,NumberLine =2)]
        [DataGrid(WidthColonne =150,Ordre =0)]
        [Filter(Ordre =0,WidthControl =150)]
        public LocalizedString Title { set; get; }



        [EntryForm(WidthControl = 200, Ordre = 2, MultiLine = true, NumberLine = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(Ordre = 2, WidthControl = 150)]
        public LocalizedString Description { set; get; }



        [EntryForm(WidthControl = 200, Ordre = 1)]
        [DataGrid(WidthColonne = 150, Ordre =1)]
        [Filter(Ordre = 1,isDefaultIsEmpty =true, WidthControl = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.OneToMany)]
        public virtual List<ProjectTask> ProjectTasks { set; get; }

       

    }

   
}
