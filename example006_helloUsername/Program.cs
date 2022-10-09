Console.WriteLine("Введите имя пользователя -> ");
string username = Console.ReadLine();
if(username.ToLower() == "саша")  // .ToLower - перевод всех символов строки в НИЖНИЙ регисрт
{
    Console.WriteLine("Ух ты это же Саша");
}
else
{
    Console.Write("Привет : ");
    Console.WriteLine(username);
}