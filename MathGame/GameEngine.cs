namespace MathGame {

  internal class GameEngine {

    internal void AdditionGame(string message) {
        Console.WriteLine(message);
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();

            if (int.Parse(result!) == (firstNumber + secondNumber)) {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            } else {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, "Addition");
        Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
        Console.ReadLine();
    }

    internal void SubtractionGame(string message) {
        Console.WriteLine(message);
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();

            if (int.Parse(result!) == (firstNumber - secondNumber)) {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            } else {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, "Subtraction");
        Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
        Console.ReadLine();
    }

    internal void DivisionGame(string message) {
        Console.WriteLine(message);
        var score = 0;

        for (int i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var result = Console.ReadLine();

            if (int.Parse(result!) == (firstNumber / secondNumber)) {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            } else {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, "Division");
        Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
        Console.ReadLine();
    }

    internal void MultiplicationGame(string message) {
        Console.WriteLine(message);
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++) {
            Console.Clear();
            Console.WriteLine(message);
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();

            if (int.Parse(result!) == (firstNumber * secondNumber)) {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            } else {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Helpers.AddToHistory(score, "Multiplication");
        Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
        Console.ReadLine();
    }
  }
}