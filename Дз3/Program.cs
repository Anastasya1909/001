//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i %2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");
}
