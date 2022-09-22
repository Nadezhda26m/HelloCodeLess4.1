// Персональное приветствие для Маши
Console.Clear();
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша") // возвращает введенный текст в нижнем регистре
{
    Console.Write("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
