// Напишите программу, которая на вход принимает число и 
//выдает, является ли число четным.
Console.WriteLine("Введите число:");
string input = Console.ReadLine();

int number = int.Parse(input); 

if (number%2 ==0)
{
    Console.WriteLine($"Число {number} четное");
}
else
{
    Console.WriteLine($"Число {number} не четное");
}