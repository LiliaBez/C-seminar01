//Задача с семинара
Console.WriteLine("Введите число");
string input = Console.ReadLine(); // пользовательский ввод
int number = int.Parse(input); //если ошибка, программа вылетает, более нежная команда if (int.TryParse (input))
int square = number * number; // квадрат
Console.WriteLine($"Число в квадрате равно {square}");
// другой вариант Console.WriteLine("Число в квадрате равно {0}", square);