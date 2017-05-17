using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using Entities.TrainingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ModuleManagement
{
   public class Precision:BaseEntity
    {
        public Precision()
        {
            Name = new LocalizedString();
            Description = new LocalizedString();
        }
        public LocalizedString Name { set; get; }

        //
        // Duree
        //
      
        public int Duration { set; get; }

        public LocalizedString Description { set; get; }

        //
        // Module
        //
       
        public  Module Module { set; get; }


        
        //public virtual List<Prealable> Prealables { set; get; }

        public  List<PrecisionContent> PrecisionContents { set; get; }
    }
}
