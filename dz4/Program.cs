// Напишите программу, которая принимает на вход три числа 
//и выдает максимальное из этих чисел.
Console.WriteLine("Введите число A");
string input = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите число B");
string input2 = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите число C");
string input3 = Console.ReadLine(); // пользовательский ввод

int FirstNumber = int.Parse(input);
int SecondNumber = int.Parse(input2);
int ThirdNumber = int.Parse(input3);

if (FirstNumber > SecondNumber)
{
    if (FirstNumber > ThirdNumber)
    {
        Console.WriteLine($"Максимальное число {FirstNumber}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {ThirdNumber}");
    }
}
else if (SecondNumber > ThirdNumber)
{
    Console.WriteLine($"Максимальное число {SecondNumber}");
}
else
{
    Console.WriteLine($"Максимальное число {ThirdNumber}");
}



