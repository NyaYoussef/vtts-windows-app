using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Gwin.Application.BAL;
using App.Gwin.Entities;

namespace vtts.Presentation.MissionManagement
{
    public partial class MissionConvocationFrom : App.Gwin.BaseEntryForm
    {
        

        public MissionConvocationFrom(IGwinBaseBLO EtityBLO,
          BaseEntity entity,
          Dictionary<string, object> critereRechercheFiltre,
          bool AutoGenerateField) : base(EtityBLO, entity, critereRechercheFiltre, false)
        {
            InitializeComponent();
        }

        public MissionConvocationFrom(IGwinBaseBLO service)
            : this(service, null, null, false) { }


        private void MissionCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
