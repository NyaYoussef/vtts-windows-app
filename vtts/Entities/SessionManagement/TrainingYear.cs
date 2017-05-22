using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace vtts.Entities.SessionManagement
{

    [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
    [Menu(Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grif_title")]
    public class TrainingYear : BaseEntity
   {

        public TrainingYear()
        {
            Title = new LocalizedString();
        }
     
        [EntryForm(Ordre = 1,WidthControl =200,isRequired =true)]
        [Filter(Ordre =1,WidthControl =150)]
        [DataGrid(WidthColonne = 150,Ordre =1)]
        public LocalizedString Title { set; get; }


       
        [EntryForm(Ordre = 2,WidthControl =200)]
        [DataGrid(WidthColonne = 150,Ordre =2)]
        public DateTime StartDate { set; get; }

       
      
        [EntryForm(Ordre = 3,WidthControl =200)]
        [DataGrid(WidthColonne = 150,Ordre =3)]
        public DateTime EndDate { set; get; }

    }
}