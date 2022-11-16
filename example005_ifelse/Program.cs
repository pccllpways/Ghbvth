Console.WriteLine("вводи имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "максим")
{
    Console.WriteLine("ура, это же Максим");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}