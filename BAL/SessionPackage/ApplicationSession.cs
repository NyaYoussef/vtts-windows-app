using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.WinForm.Entities.Authentication;
using App.WinForm.Forms;
using App.WinForm.Security;
using App.WinForm.Application.Security;
using App.WinForm.Application.BAL;
using App;

namespace BAL.SessionPackage
{
    public class ApplicationSession
    {
       

        public ApplicationSession(BaseForm ApplicationMenu, User user, CultureInfo CultureInfo)
        {
            ApplicationInstance.Session = new Session(ApplicationMenu, user, CultureInfo.CreateSpecificCulture("fr"));
            InstallApplication installApplication = new InstallApplication(typeof(ModelContext));
            installApplication.Update();

        }
    }
}
