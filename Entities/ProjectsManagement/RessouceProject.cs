using App.Entities.ProjectsManagement;
using App.WinForm.Attributes;
using App.WinForm.Entities.ContactInformations;
using App.WinForm.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.ProjectsManagement
{
    [DisplayEntity(Localizable = true, DisplayMember = "Name")]
    [SelectionCriteria(typeof(Country), typeof(City))]
    [Menu]
    public class RessouceProject : Person
    {
         public virtual List<Project> Project { set; get; }
    }
}
