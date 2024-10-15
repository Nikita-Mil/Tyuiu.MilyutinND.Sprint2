using tyuiu.cources.programming.interfaces.Sprint2;
//Написать программу на, которая запрашивает целые значения с клавиатуры
//и вычисляет находится ли точка с координатами X,Y в заштрихованной области.
namespace Tyuiu.MilyutinND.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((y == 3 & (x == 3 && x <= 5)) || (y == 4 & (x == 3 && x <= 5)) || ((y == 5 & (x >= 5 && x <= 9)) || ((y == 6 & (x >= 5 && x <= 9)) ||
            ((x == 9 && (y >= 3 || y <= 4)) || ((y == 7 && (x >= 3 | x <= 13)) || ((x == 12 & (y >= 3 & y <= 8)) || ((x == 13 & (y >= 6 && y <= 8)) ||
            ((x == 4 & (y >= 8 & y <= 13)) || ((x == 3 & y == 11) || (y == 14 & ((x >= 5 && y <= 6)) || ((x == 8 & (y >= 8 && y <= 12)) || ((x == 9 & (y >= 8 && y <= 12)) ||
            ((x == 10 & (y >= 8 && y <= 12)) || ((y == 11 && (x >= 11 & x <= 12)) || ((x == 11 & y == 8))))))))))))))))
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
