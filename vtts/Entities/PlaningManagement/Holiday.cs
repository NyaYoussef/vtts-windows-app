using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Entities.SessionManagement;

namespace vtts.Entities.PlaningManagement
{
     public class Holiday : BaseEntity
    {
          public Holiday()
        {
            Title = new LocalizedString();
        }
        public LocalizedString Title { set; get; }

        public DateTime StartDate { set; get; }

       
        public DateTime EndDate { set; get; }


     
        public virtual TrainingYear TrainingYear { set; get; }
    }
}
