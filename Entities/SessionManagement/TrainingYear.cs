using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;

namespace Entities.SessionManagement
{

    [DisplayEntity(Localizable =true,DisplayMember ="Title")]
    [Menu]
    public class TrainingYear : BaseEntity
   {

        public TrainingYear() : base()
        {
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
        }


        public override string ToString() => this.Title;

     
        [DisplayProperty(isInGlossary =true)]
        [EntryForm(Ordre = 1)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public String Title { set; get; }


        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 2)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public DateTime StartDate { set; get; }

       
        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 3)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public DateTime EndDate { set; get; }

    }
}