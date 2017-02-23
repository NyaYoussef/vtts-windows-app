using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.TraineeManagement;
using App.WinForm.Application.BAL;

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