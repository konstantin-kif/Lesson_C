// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).

// Функция, на вход получает параметр, на выходе введенные с консоли значение
int Prompt(string massage)
{
    System.Console.Write(massage);             // Вывести сообщение
    string readValue = Console.ReadLine();      // Считывает с консоли строку
    int result = int.Parse(readValue);         // Преобразует строку в целое число
    return result;                             //  Возвращает результат
}

int Value;                                     // Объявление переменной
Value = Prompt("Введите число >");            // Вводим значение
int result = Value * Value;                    // (Переменную можно объявлять и сразу присваевать ей значение) Вычесляем квадрат
System.Console.WriteLine($"Квадрат числа {Value} равен {result}");           // Вывод результата    
System.Console.WriteLine($"Квадрат числа " + Value + " равен " + result);       // Вывод результата   