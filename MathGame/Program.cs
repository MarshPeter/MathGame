using MathGame;

var menu = new Menu();
var date = DateTime.UtcNow;

List<string> games = new();

string name = GetName()!;

menu.ShowMenu(name, date);

string? GetName() {
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}
