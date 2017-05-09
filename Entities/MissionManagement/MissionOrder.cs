using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MissionManagement
{
    public class MissionOrder
    {
        public DateTime Date { set; get; }

        public Mission Mission { set; get; }
        
        public string OrderNumber { set; get; }

        public DateTime DepartureDate { set; get; }
        public DateTime ArrivalDate { set; get; }


        // Means of transport

    }
}
