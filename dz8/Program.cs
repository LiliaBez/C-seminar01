// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();

int number = int.Parse(input);

Console.WriteLine($"Ряд четных чисел от 1 до {number}: ");
for (int i = 2; i <= number; i = i+2)
{
    Console.Write(i);
    Console.Write(' ');
}
