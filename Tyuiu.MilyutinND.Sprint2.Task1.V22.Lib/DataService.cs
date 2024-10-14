using tyuiu.cources.programming.interfaces.Sprint2;
//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений,
//которая вернет логическую последовательность(массив):
//(True, True, True, False, False, False),
//при a = 324, b = 696, c = 254, d = 155
namespace Tyuiu.MilyutinND.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a+400>b) | (c<d+200);
            res[1] = (a+500>b) & (c<d+200);
            res[2] = (a + 400 > b) || (c < d);
            res[3] = (a > b) && (c < d);
            res[4] = !(res[0]);
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
