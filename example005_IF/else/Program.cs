Console.Write(" Введите имя пользователя: ");
string userName = Console.ReadLine( );
if (userName.ToLower() == "Маша")
{
    Console.WriteLine ("Ого, это же Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(userName);
}