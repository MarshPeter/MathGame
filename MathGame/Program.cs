var date = DateTime.UtcNow;

List<string> games = new();

string name = GetName()!;

Menu(name, date);

void AdditionGame(string message) {
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

    AddToHistory(score, "Addition");
    Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
    Console.ReadLine();
}

void SubtractionGame(string message) {
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
    AddToHistory(score, "Subtraction");
    Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
    Console.ReadLine();
}

void DivisionGame(string message) {
    Console.WriteLine(message);
    var score = 0;

    for (int i = 0; i < 5; i++) {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
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
    AddToHistory(score, "Division");
    Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
    Console.ReadLine();
}

void MultiplicationGame(string message) {
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
    AddToHistory(score, "Multiplication");
    Console.WriteLine($"Game Over! Your score was: {score}. Press any key.");
    Console.ReadLine();
}

void Menu(string? name, DateTime date) {
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
                AdditionGame("Addition Game");
                break; 
            case "s":
                SubtractionGame("Subtraction Game");
                break;
            case "m":
                MultiplicationGame("Multiplication Game");
                break;
            case "d":
                DivisionGame("Division Game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                break;
            case "v":
                GetGames();
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    } while (isGameOn);
}

void GetGames() {
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("---------------------------------");
    foreach (var game in games) {
        Console.WriteLine(game);
    }
    Console.WriteLine("---------------------------------\n");
    Console.WriteLine("Press any button to return to the Main Menu");
    Console.ReadLine();
}

string? GetName() {
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

int[] GetDivisionNumbers() {
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);
    var result = new int[2];

    while (firstNumber % secondNumber != 0) {           
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;
    return result;
}

void AddToHistory(int score, string gameType) {
    games.Add($"{DateTime.Now} - {gameType}: Score = {score}");
}