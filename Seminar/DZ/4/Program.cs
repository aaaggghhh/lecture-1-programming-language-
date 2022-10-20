//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число от 0 до 4294967295: ");
uint number = uint.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)

{
if (i % 2 == 0)

    Console.WriteLine(i);
}


 









