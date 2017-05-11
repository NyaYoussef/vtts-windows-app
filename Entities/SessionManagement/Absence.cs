using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SessionManagement
{
    public class Absence:BaseEntity
    {
        public DateTime AbsenceDate { get; set; }
        public string CauseOfAbsence { get; set; }

    }
}
