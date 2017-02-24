using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.ProjectsManagement
{
    /// <summary>
    /// Cette classe doit contenire seulement la configuration Minimale
    /// il est utiliser par le projet de Test pour tester le fonctionnement d'une gestion
    /// avec la configuration minimale
    /// </summary>
    [DisplayEntity(isMaleName = false, DisplayMember = "Name", Localizable = true)]
    [Menu]
    public class ProjectCategory : BaseEntity
    {
        [DisplayProperty(isInGlossary = true)]
        [EntryForm]
        [Filter]
        [DataGrid]
        public string Name { set; get; }

        [DisplayProperty(isInGlossary =true)]
        [EntryForm(MultiLine = true)]
        [DataGrid]
        public string Description { set; get; }
    }
}
