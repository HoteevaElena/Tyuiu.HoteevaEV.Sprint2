using Tyuiu.HoteevaEV.Sprint2.Task2.V2.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 3;
            bool wait = true;

            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}