using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HoteevaEV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if(((y > (2 - x)) && (y < (x * x)) && (x < 0) && (y > 0)) || 
                ((y < (x * x)) && (y < 2 - x) && (y >= 0) && (x >= 0)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }   
    }
}
