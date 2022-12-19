//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (b < max) 
{
    max = a; 
    min = b;
}
if (b > max) 
{
    max = b; 
    min = a;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
