using Tyuiu.HoteevaEV.Sprint2.Task7.V12.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = -2.5;
            double y = 6;
            bool wait = true;
            bool reslt = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, reslt);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();

            double x = 0.8;
            double y = 0.5;
            bool wait = true;
            bool reslt = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, reslt);
        }
    }
}