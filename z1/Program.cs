Console.WriteLine("Введите число A");
string input = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите число B");
string input2 = Console.ReadLine(); // пользовательский ввод

int numberA = int.Parse(input); //если ошибка, программа вылетает, более нежная команда if (int.TryParse (input))
int numberB = int.Parse(input2); //если ошибка, программа вылетает, более нежная команда if (int.TryParse (input))


double quot = numberA / numberB; // частное
if (quot<=numberB)
{
Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else 
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}

