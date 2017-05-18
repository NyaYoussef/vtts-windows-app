using App.Gwin.Entities;
using vtts.Entities.MissionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.BAL
{
   public  class MissionOrderBLO : BaseBLO<MissionOrder>
    {
        public override void ApplyBusinessRolesAfterValuesChanged(object sender, BaseEntity entity)
        {
            MissionOrder entityMiniConfig = entity as MissionOrder;
            string field_name = (string)sender;

            switch (field_name)
            {
      
                case nameof(MissionOrder.MeansTransportCategory):
                    {
            entityMiniConfig.OrderNumber = entityMiniConfig.OrderNumber + " " + entityMiniConfig.MeansTransportCategory;
        }
                    break;
            }
}

    }
}
