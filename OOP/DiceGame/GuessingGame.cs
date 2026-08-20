namespace OOP.DiceGame;

public class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        int diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries");

        var triesLeft = InitialTries;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter your guess number: ");
            if (guess == diceRollResult)
            {
                return GameResult.Victory;
            }

            --triesLeft;
            Console.WriteLine($"Wrong guess. {triesLeft} tries remaining.");
        }

        return GameResult.Loss;
    }

    public void PrintGameResult(GameResult gameResult)
    {
        string message = gameResult == GameResult.Victory
            ? "Congratulations! You won!"
            : "Sorry!:( Better luck next time!";
        Console.WriteLine(message);
    }
}