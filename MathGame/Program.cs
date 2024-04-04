using MathGame;

var menu = new Menu();

string userName = GetName();

var date = DateTime.Now;

var gamesHistory = new List<string>();

string GetName()
{
    Console.WriteLine("Please, type your name: ");
    var name = Console.ReadLine();
    return name;
}

menu.ShowMenu(userName, date);
