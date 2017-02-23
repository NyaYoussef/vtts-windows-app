using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WinForm;
using App.WinFrom.Menu;
using System.Resources;
using System.Globalization;
using System.Threading;
using App.WinForm.Security;
using App.WinForm.Entities;
using App.WinForm.Application.Security;
using App.WinForm.Forms;
using App.WinForm.Entities.Authentication;
using App.WinForm.Forms.FormMenu;
using App;
using App.WinForm.Application.BAL;
using BAL.SessionPackage;
using App.WinForm.Entities.Application;

namespace vtts
{
    public partial class FormMenu : BaseForm, IApplicationMenu
    {
        public FormMenu()
        {
            User user = new User();
            user.Name = "ES-SARRAJ";
            user.FirstName = "Fouad";

            ApplicationSession session = new ApplicationSession(this, user, CultureInfo.CreateSpecificCulture("fr"));
          


            Reload();
        }
        public override void Reload()
        {
            this.Controls.Clear();
            InitializeComponent();
            AfficherFormulaire = new ShowEntityManagementForm(new BaseBAO<BaseEntity>(), this);
            new ConfigMenuApplication(new BaseBAO<MenuItemApplication>(), this);
        }

        #region IBaseForm
        public MenuStrip getMenuStrip()
        {
            return this.menuStrip1;
        }
       
        #endregion



        ShowEntityManagementForm AfficherFormulaire { set; get; }
        private void binfingNavigatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void FormMenu_Load(object sender, EventArgs e)
        {
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ApplicationInstance.Session.Change_Culture(CultureInfo.CreateSpecificCulture("fr"));
            this.RightToLeftLayout = false;
            this.RightToLeft = RightToLeft.No;

        }

        private void anglaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationInstance.Session.Change_Culture(CultureInfo.CreateSpecificCulture("en"));
            this.RightToLeftLayout = false;
            this.RightToLeft = RightToLeft.No;


        }

        private void arabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationInstance.Session.Change_Culture(new CultureInfo("ar"));
        }
     
    }
}
