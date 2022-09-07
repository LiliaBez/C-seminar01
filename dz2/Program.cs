// Напишите программу, которая на вход принимает два числа 
//и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите число A");
string input = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите число B");
string input2 = Console.ReadLine(); // пользовательский ввод

int FirstNumber = int.Parse(input);
int SecondNumber = int.Parse(input2);

if (FirstNumber == SecondNumber)
{
    Console.WriteLine("Эти числа равны");
}
else if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"Число {FirstNumber} большее, число {SecondNumber} меньшее");
}
else
{
    Console.WriteLine($"Число {SecondNumber} большее, число {FirstNumber} меньшее");
}
