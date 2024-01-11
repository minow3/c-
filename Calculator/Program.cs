using System.Net;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    //Tomas Bendaravicius
    {
        //Console settings
        #pragma warning disable CS8602
        #pragma warning disable CS8603
        Console.Title = "MoneyBag Insurance Group LTD";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;

        // Privet information
        string? agent1 = "Risky Rich";
        string? agent1Pass = "1234";
        string? enterPass;

        //Program starting point
        Console.Clear();
        Loading();
        Console.Clear();
        System.Threading.Thread.Sleep(500);
        StartingMenu();

        //Agent code verification
        while (true)
        {
            Console.WriteLine("\n  Please enter agent code:\n");
            enterPass = Console.ReadLine();

            if (enterPass == agent1Pass)
            {
                break;
            }
            else
            {   
                Console.Clear();
                StartingMenu();
                Console.WriteLine("\n  Invalid code !!!");
                Console.WriteLine("\n  Please try again:");

            }
        }

        //Starting insurance calculation
        ContinueMenu(agent1);

        //Repeat insurance quote
        bool newQuote = true;
        //Main Program
        while (newQuote)
        {
            //General base 
            double baseQuote = 250.0;

            // Get user's name and surname
            ContinueMenu(agent1);
            string? userName = GetUserName();
            ContinueMenu(agent1);
            string? userSurname = GetUserSurname();

            //Get gender
            ContinueMenu(agent1);
            double genderMultiplier = GetGenderMultiplier();

            //Get user age
            ContinueMenu(agent1);
            int age = GetAge();

            //Calculate age group
            ContinueMenu(agent1);
            double ageMultiplier = GetAgeMultiplier(age);

            //Ask if user has health condition
            ContinueMenu(agent1);
            double healthConditionMultiplier = GetHealthConditionMultiplier();

            //Ask if user smoke
            ContinueMenu(agent1);
            double smokingMultiplier = GetSmokingMultiplier();

            //Get all values and calculate quote
            double finalQuote = CalculateQuote(baseQuote, genderMultiplier, ageMultiplier, healthConditionMultiplier, smokingMultiplier);

            // Print personalized message with included quote
            ContinueMenu(agent1);
            PrintPersonalizedMessage(userName, userSurname, finalQuote);

            //Ask agent for another quote
            Console.WriteLine("\n\n  Do you want to get another quote? (y/n)");
            newQuote = Console.ReadLine().ToLower() == "y";

        }
    }

    static void Loading()
    //Program starts
    //Tomas Bendaravicius
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\tInitiating...");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("\n\n\n\tLoading network...");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("\n\n\n\tDownloading data...");
        System.Threading.Thread.Sleep(3000);

    }

    static void StartingMenu()
    //Title
    //Tomas Bendaravicius
    {
        Clock();
        Console.WriteLine("\n\n  MoneyBag Insurance Group LTD\n");

    }

    static void ContinueMenu(string? agent1)
    //Main menu
    //Tomas Bendaravicius
    {
        Console.Clear();
        StartingMenu();
        Console.WriteLine($"\n  Welcome agent: {agent1}\n");

    }
    
    static void Clock()
    // Current time
    //Tomas Bendaravicius
    {
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine("\n  Current date and time: " + formattedDateTime);

    }

    static string GetUserName()
    //Get user name
    //Tomas Bendaravicius
    {
        Console.WriteLine("\n  Provide quote person name:");
        return Console.ReadLine();

    }

    static string GetUserSurname()
    //Get user surname
    //Tomas Bendaravicius
    {
        Console.WriteLine("\n  Provide quote person surname:");
        return Console.ReadLine();

    }

    static void PrintPersonalizedMessage(string userName, string userSurname, double finalQuote)
    //Printing final code
    //Tomas Bendaravicius
    {
        Console.WriteLine($"\n  Dear {userName} {userSurname},");
        Console.WriteLine($"\n  Your insurance quote is: {finalQuote} euros");

    }

    static double GetGenderMultiplier()
    //Calculate by gender
    // Juozas Sadauskas
    {
        Console.WriteLine("\n  Select gender: (1) Male, (2) Female");
        int genderChoice = Convert.ToInt32(Console.ReadLine());
        return (genderChoice == 1) ? 2.0 : 0.7;

    }

    static int GetAge()
    //Get user age
    //Sarune Matiukaite
    {
        Console.WriteLine("\n  Enter age:");
        return Convert.ToInt32(Console.ReadLine());

    }

    static double GetAgeMultiplier(int age)
    //Calculating age groups
    //Sarune Matiukaite
    {
        if (age < 35)
        {
            return 1.2;
        }
        else if (age >= 35 && age <= 55)
        {
            return 1.4;
        }
        else if (age >= 56 && age <= 70)
        {
            return 1.65;
        }
        else
        {
            //Users over 71 are not provided with quote
            Console.WriteLine("\n  Sorry, no quote for individuals over 70.");
            Environment.Exit(0);//Closing program
            return 0; // This line is never reached, but needed for the compiler

        }
    }

     static double GetHealthConditionMultiplier()
     //Calculating health condition
     // Juozas Sadauskas
    {
        Console.WriteLine("\n  Do you have existing health conditions? (y/n)");
        bool hasHealthCondition = Console.ReadLine().ToLower() == "y";
        return hasHealthCondition ? 1.5 : 1.0;

    }

    static double GetSmokingMultiplier()
    //Calculating if user smokes
    // Juozas sadauskas
    {
        Console.WriteLine("\n  Do you smoke? (y/n)");
        bool isSmoker = Console.ReadLine().ToLower() == "y";
        return isSmoker ? 75 : -100;

    }

    static double CalculateQuote(double baseQuote, double genderMultiplier, double ageMultiplier, double healthConditionMultiplier, double smokingMultiplier)
    //Main calculation formula
    //Tomas Bendaravicius
    {
        return baseQuote * genderMultiplier * ageMultiplier * healthConditionMultiplier + smokingMultiplier;
    }
}
