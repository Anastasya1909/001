//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = -9;
int b = -3;


int max = a;
int min = a;

if (a > max) 
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
