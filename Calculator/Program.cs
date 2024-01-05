internal class Program
{
    private static void Main(string[] args)
    {
        // Console UX
        Console.Title = "MoneyBag insurance Group LTD";

        // Agent Information
        string? agent = "Risky Riches"; // Agent name

        // Repeat insurance quote
        bool newQuote = true;
        int menuChose;
        int tryAgain;

        // Standard Rates ( Can be adjusted here )
        int generalBase = 250; // Starting general base value

        // User information
        string? userName;
        string? userSurname;
        int userAge;

        // Main Program
        EntranceMessage();
        PasswordManager();
        

        while (newQuote)
        {
            Console.WriteLine("Insurance Quote Calculator");

            double baseQuote = 250.0;

            double genderMultiplier = GetGenderMultiplier();
            int age = GetAge();
            double ageMultiplier = GetAgeMultiplier(age);
            double healthConditionMultiplier = GetHealthConditionMultiplier();
            double smokingMultiplier = GetSmokingMultiplier();

            double finalQuote = CalculateQuote(baseQuote, genderMultiplier, ageMultiplier, healthConditionMultiplier, smokingMultiplier);

            Console.WriteLine($"Your insurance quote is: {finalQuote} euros");

            Console.WriteLine("Do you want to get another quote? (y/n)");
            newQuote = Console.ReadLine().ToLower() == "y";

            
        }
        


    }

    static void Clock() // Current time
    {
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine("Current date and time: " + formattedDateTime);
    }

    static void EntranceMessage() //
    {
        Console.Clear();
        Clock();
        Console.WriteLine("\n\n\tMoneyBag Insurance Group LTD");
        Console.WriteLine("\n\n\tPlease enter authentication code");

    }

    static void AdminInterface(string agent)
    {
        Clock();
        Console.WriteLine("\n\n\tMoneyBag Insurance Group LTD");
        Console.WriteLine("\n\t\t\t\tAgent: " + agent);
        Console.WriteLine("\n\n\tMenu options");
        Console.WriteLine("\n\t1 - New quote");
        Console.WriteLine("\n\t2 - General information");
        Console.WriteLine("\n\t0 - EXIT");

    }

    static void PasswordManager()
    {   
        while (true)
        {
            int agentPass = 1234;   // Agent password
            int agentProvidedPass = Convert.ToInt32(Console.ReadLine());

            if (agentProvidedPass == agentPass)
            {
                continue;
            }
            else //(agentProvidedPass != agentPass)
            {
                Console.Clear();
                Clock();
                Console.WriteLine("\n\n\tMoneyBag Insurance Group LTD");
                Console.WriteLine("\n\tInvalid code");
                Console.WriteLine("\n\tProvide correct authentication code");
            }
            
        }
        
    }



}