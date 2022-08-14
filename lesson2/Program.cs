// 1. Напишите программу, котрая на вход принимает два числа и 
// проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> Да
// a = 5; b = 10 -> Нет
// a = 9; b = -3 -> Нет
// a = -3; b = 9 -> Да

int Prompt(string massage)
{
    System.Console.Write(massage);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Value1;
int Value2;
Value1 = Prompt("Введите первое число: ");
Value2 = Prompt("Введите второе число: ");
if (Value1 * Value1 == Value2)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
