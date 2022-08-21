// Вид методов 1 (ни чего не принимаютни и ни чего не возращают).
void Method1()
{
    Console.WriteLine("Автор Константин");
}
Method1();

// Вид методов 2 (принимают, но ни чего не возращают).
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Cообщение");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);

// Вид методов 3 (ни чего не принимают, но что-то возращают).
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид методов 4 (что-то принимают и что-то возращают).
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string result = Method4(10, "z");
Console.WriteLine(result);