﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HoteevaEV.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x <= 5 && x >= 3) && y == 3) || (x == 5 && y == 4) || ((x > 2 && x < 5) && ( y == 6 || y == 7)) || 
                ((x >= 5 && x <= 10) && (y == 5  || y == 6))  || ((x == 9 || x == 10) && (y == 3 || y == 4)) 
                || ((x >= 8 && x <= 12) && (y >= 7 && y <= 9)) ||
                (x == 7 && y == 9) || ((x == 8 || x ==9) && (y == 10 || y == 11)) || ((x >= 4 && x <= 7) 
                && (y >= 11 && y <= 13)) || (x == 3 && y == 11) || 
                (x == 12 && (y >= 3 && y <= 6)) || (x == 13 && (y >= 6 && y <= 8)))
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
