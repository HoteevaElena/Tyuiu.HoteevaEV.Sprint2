using Tyuiu.HoteevaEV.Sprint2.Task4.V13.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double wait = 53.75;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 20;
            double wait = 0.069;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}