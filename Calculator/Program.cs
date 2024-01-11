using System.Net;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    //Tomas Bendaravicius
    {
        #pragma warning disable CS8602
        #pragma warning disable CS8603
        Console.Title = "MoneyBag Insurance Group LTD";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;

        string? agent1 = "Risky Rich";
        string? agent1Pass = "1234";
        string? enterPass;

        Console.Clear();
        Loading();

        Console.Clear();
        System.Threading.Thread.Sleep(1000);
        StartingMenu();
        while (true)
        {
            Console.WriteLine("\n\tProvide insurance agent password:");
            enterPass = Console.ReadLine();
            if (enterPass == agent1Pass){
                break;
            }
            else
            {
                Console.WriteLine("\n\tInvalid password !!!");
                Console.WriteLine("\n\tPlease try again:");

            }
        }

        Console.Clear();
        StartingMenu();
        Console.WriteLine($"\n\tWelcome {agent1}\n");


        // Repeat insurance quote
        bool newQuote = true;
        // Main Program
        while (newQuote)
        {
            double baseQuote = 250.0;

            // Get user's name and surname
            string? userName = GetUserName();
            string? userSurname = GetUserSurname();

            double genderMultiplier = GetGenderMultiplier();
            int age = GetAge();
            double ageMultiplier = GetAgeMultiplier(age);

            double healthConditionMultiplier = GetHealthConditionMultiplier();
            double smokingMultiplier = GetSmokingMultiplier();

            double finalQuote = CalculateQuote(baseQuote, genderMultiplier, ageMultiplier, healthConditionMultiplier, smokingMultiplier);

            // Print personalized message
            PrintPersonalizedMessage(userName, userSurname, finalQuote);

            Console.WriteLine("Do you want to get another quote? (y/n)");
            newQuote = Console.ReadLine().ToLower() == "y";

            
        }
        

    }

    static void Loading()
    //Tomas Bendaravicius
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\tWelcome");
        System.Threading.Thread.Sleep(2000);
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
    //Tomas Bendaravicius
    {
        Clock();
        Console.WriteLine("\n\n\tMoneyBag insurance Group LTD\n");
    }

    static void Clock() // Current time
    //Tomas Bendaravicius
    {
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine("\nCurrent date and time: " + formattedDateTime);
    }

    static string GetUserName()
    //Tomas Bendaravicius
    {
        Console.WriteLine("Enter your name:");
        return Console.ReadLine();
    }

    static string GetUserSurname()
    //Tomas Bendaravicius
    {
        Console.WriteLine("Enter your surname:");
        return Console.ReadLine();
    }

    static void PrintPersonalizedMessage(string userName, string userSurname, double finalQuote)
    //Tomas Bendaravicius
    {
        Console.WriteLine($"Dear {userName} {userSurname},");
        Console.WriteLine($"Your insurance quote is: {finalQuote} euros");
    }

    static double GetGenderMultiplier()
    // Juozas Sadauskas
    {
        Console.WriteLine("Select gender: (1) Male, (2) Female");
        int genderChoice = Convert.ToInt32(Console.ReadLine());
        return (genderChoice == 1) ? 2.0 : 0.7;
    }

    static int GetAge()
    //Sarune Matiukaite
    {
        Console.WriteLine("Enter age:");
        return Convert.ToInt32(Console.ReadLine());
    }

    static double GetAgeMultiplier(int age)
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
            Console.WriteLine("Sorry, no quote for individuals over 70.");
            //Closing program
            Environment.Exit(0);
            

            return 0; // This line is never reached, but needed for the compiler
        }
    }

     static double GetHealthConditionMultiplier()
     // Juozas Sadauskas
    {
        Console.WriteLine("Do you have existing health conditions? (y/n)");
        bool hasHealthCondition = Console.ReadLine().ToLower() == "y";
        return hasHealthCondition ? 1.5 : 1.0;
    }

    static double GetSmokingMultiplier()
    // Juozas sadauskas
    {
        Console.WriteLine("Do you smoke? (y/n)");
        bool isSmoker = Console.ReadLine().ToLower() == "y";
        return isSmoker ? 75 : -100;
    }

    static double CalculateQuote(double baseQuote, double genderMultiplier, double ageMultiplier, double healthConditionMultiplier, double smokingMultiplier)
    {
        return baseQuote * genderMultiplier * ageMultiplier * healthConditionMultiplier + smokingMultiplier;
    }
}
