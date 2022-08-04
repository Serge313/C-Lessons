Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine("Привет, Настя!");
}
else
{
    Console.Write("Здравствуй, ");
    Console.WriteLine(username);
}