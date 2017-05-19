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
   
    public class Project  :BaseEntity
    {
        public Project()
        {
            Title = new LocalizedString();
            Description = new LocalizedString();
        }
       
        public LocalizedString Title { set; get; }



        public LocalizedString Description { set; get; }


       
       public virtual List<Task> Tasks { set; get; }

       

    }

   
}
