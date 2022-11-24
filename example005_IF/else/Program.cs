Console.Write("Введите имя пользователя:");
string userName = Console.ReadLine( );

if (userName.ToLower()== "Маша")
{
    Console.WriteLine("это!");
}

else 
{
    Console.Write("Привет, ");
    Console.Write(userName);
}