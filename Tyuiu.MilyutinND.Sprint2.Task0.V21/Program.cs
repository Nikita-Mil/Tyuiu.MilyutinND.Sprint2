using Tyuiu.MilyutinND.Sprint2.Task0.V21.Lib;
//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений,
//которая вернет логическую последовательность(массив): (False, False, False, False, False, False), при x = 1705, y = 775
Console.Title = "Спринт #2 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последо-*");
Console.WriteLine("* вательность операций не должна нарушаться) и арифметических выражений,  *");
Console.WriteLine("* которая вернет логическую последовательность(массив): (False, False,    *");
Console.WriteLine("* False, False, False, False), при x = 1705, y = 775                      *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int x = 1705;
int y = 775;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();