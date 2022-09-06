Console.WriteLine("Введите число A");
string input = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите число B");
string input2 = Console.ReadLine(); // пользовательский ввод

int numberA = int.Parse(input); 
int numberB = int.Parse(input2); 


double quot = numberA / numberB; // частное
if (quot<=numberB)
{
Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else 
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}

