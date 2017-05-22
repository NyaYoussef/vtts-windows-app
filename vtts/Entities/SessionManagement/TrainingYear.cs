using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace vtts.Entities.SessionManagement
{

    [GwinEntity(Localizable =true,isMaleName =false,DisplayMember ="Title")]
    [Menu(Group ="SessionManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =780)]
    public class TrainingYear : BaseEntity
   {

        public TrainingYear()
        {
            Title = new LocalizedString();
        }
     
        [EntryForm(Ordre = 1,WidthControl =250,isRequired =true)]
        [Filter(Ordre =1,WidthControl =100)]
        [DataGrid(WidthColonne = 150,Ordre =1)]
        public LocalizedString Title { set; get; }


       
        [EntryForm(Ordre = 2,WidthControl =250)]
        [DataGrid(WidthColonne = 150,Ordre =2)]
        public DateTime StartDate { set; get; }

       
      
        [EntryForm(Ordre = 3,WidthControl =250)]
        [DataGrid(WidthColonne = 150,Ordre =3)]
        public DateTime EndDate { set; get; }

    }
}