Random random = new Random();
int secretNumber = random.Next(1, 101);
int guess = 0;
int guessCount = 0;

Console.WriteLine("Welcome to Guess A Number!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");

while (guess != secretNumber)
{
    Console.Write("Enter your guess: ");
    guess = Convert.ToInt32(Console.ReadLine());
    guessCount++;

    if (guess < secretNumber)
    {
        Console.WriteLine("Too low. Try again.");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high. Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number in " + guessCount + " tries.");
    }
}