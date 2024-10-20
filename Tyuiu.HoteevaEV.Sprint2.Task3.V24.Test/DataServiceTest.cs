using Tyuiu.HoteevaEV.Sprint2.Task3.V24.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 60.357;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = -1;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = 0.822;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -30;
            double wait = 600.033;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}