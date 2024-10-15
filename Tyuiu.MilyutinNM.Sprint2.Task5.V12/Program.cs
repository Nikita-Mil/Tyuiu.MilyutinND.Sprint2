using Tyuiu.MilyutinNM.Sprint2.Task5.V12.Lib;
//Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.
//Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(порядковый номер месяца)
// и n(число). По заданным g, n и m определить дату предыдущего дня. Заданный год является високосным.

Console.Title = "Спринт #2 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуе-*");
Console.WriteLine("* мое значение и возвращает результат.                                    *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g(год), *");
Console.WriteLine("* m(порядковый номер месяца) и n(число).По заданным g, n и m определить   *");
Console.WriteLine("* дату предыдущего дня. Заданный год является високосным.                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int g = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = Convert.ToString(ds.FindDateOfPreviousDay(g, m, n));
Console.WriteLine(res);
Console.ReadLine();
