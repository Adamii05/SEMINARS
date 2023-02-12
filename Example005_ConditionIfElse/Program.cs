Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "таня")
{
    Console.WriteLine("Привет, Пупсик");
}
else
{
    Console.Write(username);
    Console.WriteLine(" Какое же ты чмо");
}