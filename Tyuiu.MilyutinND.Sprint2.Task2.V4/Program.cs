using Tyuiu.MilyutinND.Sprint2.Task2.V4.Lib;
//Написать программу на, которая запрашивает целые значения с клавиатуры
//и вычисляет находится ли точка с координатами X,Y в заштрихованной области.
Console.Title = "Спринт #2 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые                        *");
Console.WriteLine("* значения с клавиатуры и вычисляет находится ли                          *");
Console.WriteLine("* точка с координатами X,Y в заштрихованной области.                      *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (res)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка находится в незаштрихованной области");
}

Console.ReadKey();