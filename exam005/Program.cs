Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "лада")
{
    Console.WriteLine("Ура! Этоже Лада!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}