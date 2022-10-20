//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("введите число1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("введите число2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
    Console.WriteLine($"min = {number2}");
}
else
{
    Console.WriteLine($"max = {number2}");
    Console.WriteLine($"min = {number1}");
}