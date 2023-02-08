Console.Write("Введите имя пользователя: ");
string userneme = Console.ReadLine();

if(userneme.ToLower() == "маша")
{
  Console.WriteLine("Ура, это же МАША!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(userneme);
}