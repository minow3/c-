internal class Program
{
    private static void Main(string[] args)
    {
        // Console UX
        Console.Title = "MoneyBag insurance Group LTD";
        Console.BackgroundColor = ConsoleColor.White;
        Console.WindowHeight = 100;
        Console.WindowWidth = 60;

        // Agent Information
        string? agent = "Risky Riches"; // Agent name
        int agentPass = 1234;   // Agent password

        // Repeat insurance quote
        bool newQuote = true;
        int tryAgain;

        // Standard Rates ( Can be adjusted here )
        int generalBase = 250; // Starting general base value

        // User information
        string? userName;
        string? userSurname;
        int userAge;

        // Main Program
        WelcomeMessage();

    }

    static void WelcomeMessage()
    {
        Console.WriteLine("\n\tMoneyBag Insurance Group LTD");
    }
}