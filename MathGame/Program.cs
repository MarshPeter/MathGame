Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);

void AdditionGame(string message) {
    Console.WriteLine(message);
}
void SubtractionGame(string message) {
    Console.WriteLine(message);
}
void DivisionGame(string message) {
    Console.WriteLine(message);
}
void MultiplicationGame(string message) {
    Console.WriteLine(message);
}

void Menu(string? name, DateTime date) {
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is your math game.\n");
    Console.WriteLine(@$"What game would you like to play today? Choose options from below: 
    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division
    Q - Quit the program
    ");
    Console.WriteLine("-----------------------------------");

    var gameSelected = Console.ReadLine();
    switch (gameSelected!.Trim().ToLower()) {
        case "a":
            AdditionGame("Addition game Selected");
            break; 
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }
}