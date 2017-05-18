using Microsoft.VisualStudio.TestTools.UnitTesting;
using vtts.Entities.TraineeManagement;
using App;
using vtts.BAL;
using App.Gwin.Entities.Secrurity.Authentication;
using App.Gwin;
using vtts;

namespace App.Tests
{
    [TestClass()]
    public class BaseRepositoryTests
    {
        

        [TestMethod()]
        public void InsertTest()
        {
            //    int Expected = 1;
            //    Group  groupe = new Group();
            //    groupe.Name = "groupe 1";
            //    vtts.BAL.BaseBLO service = new BaseBLO<Group>();
            //    int Actuel = service.Save(groupe);
            //    Assert.AreEqual(Expected, Actuel);
            User user = new User();
            user.Language = GwinApp.Languages.en;
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), new FormMenu(), user);



        }
    }
}