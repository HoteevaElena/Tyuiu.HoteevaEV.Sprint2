using Tyuiu.HoteevaEV.Sprint2.Task1.V8.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;
            bool[] wait = new bool[6] { true, false, true, false, false, false };
            bool[] res = new bool[6];

            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}