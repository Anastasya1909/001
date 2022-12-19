// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int i = Convert.ToInt32(Console.ReadLine());

int x = 1;

while (x < i)
{
   Console.Write(x+1);
   Console.Write(", ");  
   x = x + 2; 
}

