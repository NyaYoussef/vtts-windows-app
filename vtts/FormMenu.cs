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
using App.Gwin;
using vtts.BAL;

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
            ModelContext db = new ModelContext();
           user = db.Users.Where(u => u.Reference == "Director").SingleOrDefault();

            //user = User.CreateRootUser(new ModelContext());

            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), this, user);
            //InitializeComponent();
        }
    }
}
