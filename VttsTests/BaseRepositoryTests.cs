using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities.TraineeManagement;
using App;

namespace App.Tests
{
    [TestClass()]
    public class BaseRepositoryTests
    {
        

        [TestMethod()]
        public void InsertTest()
        {
            int Expected = 1;
            Group  groupe = new Group();
            groupe.Name = "groupe 1";
            IBaseBAO service = new BaseBAO<Group>();
            int Actuel = service.Save(groupe);
            Assert.AreEqual(Expected, Actuel);

        }
    }
}