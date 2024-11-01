using Tyuiu.HoteevaEV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.HoteevaEV.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(2024, 12, 31));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2023, 13, 32);
            });
        }
    }
}