using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HoteevaEV.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] msv = new bool[6];

            msv[0] = x == y + 1030;
            msv[1] = x != y + 1030;
            msv[2] = x - 1200 < y;
            msv[3] = x > y + 2000;
            msv[4] = x <= y;
            msv[5] = x >= y;
            return msv;
        }
    }
}
