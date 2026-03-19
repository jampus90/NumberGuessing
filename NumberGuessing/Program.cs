namespace NumberGuessing;

public class DifficultyLevel
{
    public int Id { get; set; }
    public string LevelName { get; set; }
}

internal class Program
{
    static async Task Main(string[] args)
    {
        int userGuess = 0;

        Console.WriteLine("Rules");
        Console.WriteLine("1. Choose a number between 1 and 100.");

        Console.WriteLine("Which difficulty level do you want?");
        Console.WriteLine("Press 1 -> Easy      [10 chances]");
        Console.WriteLine("Press 2 -> Medium    [5 chances]");
        Console.WriteLine("Press 3 -> Hard.     [3 chances]");

        Random random = new Random();
        int computerNumber = random.Next(1, 101);

        HashSet<DifficultyLevel> difficultyLevels = new HashSet<DifficultyLevel>()
        {
            new DifficultyLevel{ Id = 1, LevelName = "Easy"},
            new DifficultyLevel{ Id = 2, LevelName = "Medium"},
            new DifficultyLevel{ Id = 3, LevelName = "Hard"}
        };

        int difficultyLevel = int.Parse(Console.ReadLine());

        var selected = difficultyLevels
            .Where(level => difficultyLevel == level.Id)
            .Select(l => l.LevelName)
            .FirstOrDefault();

        Console.WriteLine($"You selected {selected}");

        switch (selected)
        {
            case "Easy":
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Type your guess between 1 and 100.");
                    userGuess = int.Parse(Console.ReadLine());


                    if (userGuess == computerNumber)
                    {
                        Console.WriteLine("You won! Congratulations! :D");
                        return;
                    }
                    else if (userGuess > computerNumber)
                    {
                        Console.WriteLine($"Incorrect! The number is less than {userGuess}");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The number is greater than {userGuess}");
                    }
                }
                if (userGuess != computerNumber)
                    Console.WriteLine($"You lost! The number was {computerNumber}");
                break;

            case "Medium":
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Type your guess between 1 and 100.");
                    userGuess = int.Parse(Console.ReadLine());


                    if (userGuess == computerNumber)
                    {
                        Console.WriteLine("You won! Congratulations! :D");
                        return;
                    }
                    else if (userGuess > computerNumber)
                    {
                        Console.WriteLine($"Incorrect! The number is less than {userGuess}");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The number is greater than {userGuess}");
                    }
                }
                if (userGuess != computerNumber)
                    Console.WriteLine($"You lost! The number was {computerNumber}");
                break;

            case "Hard":
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Type your guess between 1 and 100.");
                    userGuess = int.Parse(Console.ReadLine());


                    if (userGuess == computerNumber)
                    {
                        Console.WriteLine("You won! Congratulations! :D");
                        return;
                    }
                    else if (userGuess > computerNumber)
                    {
                        Console.WriteLine($"Incorrect! The number is less than {userGuess}");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The number is greater than {userGuess}");
                    }
                }
                if (userGuess != computerNumber)
                    Console.WriteLine($"You lost! The number was {computerNumber}");
                break;
        }
    }
}