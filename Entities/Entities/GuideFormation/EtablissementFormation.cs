using App.Coordonnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GuideFormation
{
    
    public class EtablissementFormation : BaseEntity
    {
       public string Titre { set; get; }

       public string Presentation { set; get; }

       public Coordonnee Coordonnee { set; get; }
    }
}
