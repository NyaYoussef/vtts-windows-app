using App;
using App.WinForm.Application.BAL.GwinApplication;
using App.WinForm.Application.Presentation.MainForm;
using App.WinForm.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtts
{
    public partial class FormMenu : FormApplication
    {
        public FormMenu()
        {
            User user = new User();
            user.Language = Gwin.Languages.ar;

            Gwin.Start(typeof(ModelContext), typeof(BaseBLO<>), this, user);
            InitializeComponent();
        }

        public override void Reload()
        {
            this.Controls.Clear();
            base.InitializeForm();
            this.InitializeComponent();
        }
    }
}
