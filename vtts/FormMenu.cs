using App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Gwin.Application.Presentation.MainForm;
using App.Gwin.Entities.Secrurity.Authentication;
using App.Gwin.Application.Presentation.EntityManagement;
using App.Gwin;
using vtts.BAL;
using vtts.Entities.StaffManagement;
using vtts.Entities.MissionManagement;
using vtts.Presentation.PrintOrderMission;

namespace vtts
{
    public partial class FormMenu : FormApplication
    {
        public FormMenu()
        {
            InitializeComponent();   
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            User user = null;
            //user.Language = Gwin.Languages.ar;
              user = User.CreateAdminUser(new ModelContext());

            // user = User.CreateGuestUser(new ModelContext());

            // Load Director User
            // ModelContext db = new ModelContext();
            //user = db.Users.Where(u => u.Reference == "Director").SingleOrDefault();

            // user = User.CreateRootUser(new ModelContext());
            user.Language = GwinApp.Languages.fr;
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), this, user);
            //InitializeComponent();
        }
        public override void Reload()
        {
            base.Reload();
            InitializeComponent();
        }

        private void Menu_StaffManagement_Click(object sender, EventArgs e)
        {
            CreateAndShowManagerFormHelper ShowManagerFormHelper=new CreateAndShowManagerFormHelper(GwinApp.Instance.TypeDBContext, this);
            ShowManagerFormHelper.ShowManagerForm(typeof(Staff));
        }

        private void Menu_ConvocationManagement_Click(object sender, EventArgs e)
        {
            CreateAndShowManagerFormHelper ShowManagerFormHelper = new CreateAndShowManagerFormHelper(GwinApp.Instance.TypeDBContext, this);
            ShowManagerFormHelper.ShowManagerForm(typeof(MissionConvocation));
        }

        private void Menu_Mission_Order_Management_Click(object sender, EventArgs e)
        {
            CreateAndShowManagerFormHelper ShowManagerFormHelper = new CreateAndShowManagerFormHelper(GwinApp.Instance.TypeDBContext, this);
            ShowManagerFormHelper.ShowManagerForm(typeof(MissionOrder));
        }

        private void Menu_PrintMissionOrderManagement_Click(object sender, EventArgs e)
        {

            FormPrintOrderMission PrintForm = new FormPrintOrderMission();
            PrintForm.ShowDialog();
        }
    }
}
