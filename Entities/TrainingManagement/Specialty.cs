using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Entities.TrainingManagement
{

   [DisplayEntity(Localizable =true,DisplayMember ="Code")]
   [Menu]
    public class Specialty : BaseEntity 
   {

 
        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 1)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public String Title { set; get; }

        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 2,WidthControl =50)]
        [Filter]
        [DataGrid]
        public  String Code { set; get; }

        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 3,WidthControl =200,MultiLine =true)]
        public String Description { set; get; }

         
        // public  List<Module> Modules { set; get; }
    }
}