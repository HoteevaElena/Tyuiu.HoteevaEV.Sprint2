using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HoteevaEV.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] ms = new bool[6];

            ms[0] = (a + 1 == b) | (c > d);
            ms[1] = (a >= c) & (b > d);
            ms[2] = (c > d) || (b - 1 == a);
            ms[3] = (a > d) && (b < c);
            ms[4] = !ms[0];
            ms[5] = (a > d) ^ (b == c);

            return ms;
        }
    }
}
