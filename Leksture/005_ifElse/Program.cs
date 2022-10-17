// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") // ToLower - переводит в нижний регистр все значения, нужно маша написать именно маленькими
{
    Console.WriteLine ("Ура, это же Mаша");
}
else 
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}
