using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             MyShootingGame.MyLogicClass test = new MyShootingGame.MyLogicClass();

                int testResult = test.SpinningLogic();

                Assert.IsTrue(testResult < 7 && testResult > 0);

        }

        [TestMethod]
        public void TestMethod2()
        {
            MyShootingGame.MyLogicClass testshoot = new MyShootingGame.MyLogicClass();

            int testResultshoot = testshoot.ShootingLogic();

            Assert.IsTrue(testResultshoot <= 4 && testResultshoot > 0);

        }
    }
}

