using App.Gwin.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.StaffManagement
{
    public class Car
    {
        public string mark { set; get; }

        public string PlateNumber { set; get; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Staff Staff { get; set; }

        /// <summary>
        /// Determine if Car is Private or Personel
        /// </summary>
        public bool PersonelCar { get; set; }

        public float TaxPower { get; set; }
}
}
