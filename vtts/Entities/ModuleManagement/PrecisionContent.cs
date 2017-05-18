using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.ModuleManagement
{
   public class PrecisionContent:BaseEntity
    {
        public PrecisionContent()
        {
            Goal = new LocalizedString();
            Description = new LocalizedString();
        }
        public  Precision Precision { set; get; }

        public LocalizedString Goal{ set; get; }

        public int Duration { set; get; }

        public LocalizedString Description { set; get; }

    }
}
