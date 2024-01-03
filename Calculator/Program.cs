internal class Program
{
    private static void Main(string[] args)
    {
        // Console UX
        Console.Title = "MoneyBag insurance Group LTD";
        Console.BackgroundColor = ConsoleColor.White;
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

        // Actions
        //bool agentCheck = false;
        //int agentProvidedPass;

        // Main Program
        WelcomeMessage();
        PasswordManager(agentPass);


    }

    static void WelcomeMessage()
    {
        Console.WriteLine("\n\t\tMoneyBag Insurance Group LTD");
        Console.WriteLine("\n\tPlease enter authentication code\n");

    }

    static bool PasswordManager(int agentPass)
    {   
        while (true)
        {
            bool agentCheck;
            int agentProvidedPass = Convert.ToInt32(Console.ReadLine());

            if (agentProvidedPass == agentPass)
            {
                agentCheck = true;
                return agentCheck;
            }
            else
            {
                Console.WriteLine("\n\tProvide correct authentication code");
            }
        }
        
    }
}