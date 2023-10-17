namespace MathGame 
{
  internal class Menu
  {
    GameEngine gameEngine = new GameEngine();
    internal void ShowMenu(string? name, DateTime date) {
        var isGameOn = true;
        do {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game.\n");
            Console.WriteLine(@$"What game would you like to play today? Choose options from below: 
                V - View Previous Games
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
                    gameEngine.AdditionGame("Addition Game");
                    break; 
                case "s":
                    gameEngine.SubtractionGame("Subtraction Game");
                    break;
                case "m":
                    gameEngine.MultiplicationGame("Multiplication Game");
                    break;
                case "d":
                    gameEngine.DivisionGame("Division Game");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                case "v":
                    Helpers.GetGames();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (isGameOn);
    }
      
  }
}