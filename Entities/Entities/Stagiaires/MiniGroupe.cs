using App.GestionProjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GestionStagiaires
{
    public class MiniGroupe  : BaseEntity
    {
        string Nom { set; get; }
        string Description { set; get; }


        public virtual List<Stagiaire> Stagiaires { set; get; }
        public virtual List<Tache> Taches { set; get; }
    }
}
