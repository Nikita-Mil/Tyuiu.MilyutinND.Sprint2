using Tyuiu.MilyutinND.Sprint2.Task6.V8.Lib;
//Условие: Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и
//n (число). По заданным n и m определить дату предыдущего дня (принять, что n и m не характеризуют 1 января).
Console.Title = "Спринт #2 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m       *");
Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным n и m определить     *");
Console.WriteLine("* дату предыдущего дня (принять, что n и m не характеризуют 1 января).    *");

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int m, n;

Console.WriteLine("Введите номер месяца: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

string res;
if ((m < 1 || m > 12) || (n < 1 || n > 31))
{
    res = "Введено неверное значение!";
}
else
{
    res = ds.FindDateOfPreviousDay(m, n);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(res);

Console.ReadKey();
