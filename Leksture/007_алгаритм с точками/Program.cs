﻿    //   1 определить 3 точки 
    //   2 выбрать 2 любые 
    //   3 найти середину 
    //   4 поставить точку 
    //   5 выбрать случайную вершину треугольника 
    //   6 соединить ее с полученной на 4 шаге точкой 
    //   7 перейти к шагу 3 
    //   8 шаги с 3 по 7 повторить 9, 28, 31 раз////

Console.Clear();
//Console.SetCursorPosition(10, 4); // Set - отступ символов от левого края и верхнего
//Console.WriteLine("+");

int xa = 40, ya = 1, // целое число координат
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //отступ символов от левого края и верхнего
Console.WriteLine("+"); // что написать

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3); // 0, 1, 2

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // count++
}