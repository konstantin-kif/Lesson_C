Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "константин")
{
    Console.WriteLine("Ура, это же Константин!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}