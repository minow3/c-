using System.Security.Cryptography.X509Certificates;

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
        // Main Program
        while (newQuote)
        {
            Console.WriteLine("MoneyBag insurance Group LTD");

            double baseQuote = 250.0;

            // Get user's name and surname
            string userName = GetUserName();
            string userSurname = GetUserSurname();

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

    static void Clock() // Current time
    {
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine("Current date and time: " + formattedDateTime);
    }

    static string GetUserName()
    {
        Console.WriteLine("Enter your name:");
        return Console.ReadLine();
    }

    static string GetUserSurname()
    {
        Console.WriteLine("Enter your surname:");
        return Console.ReadLine();
    }

    static void PrintPersonalizedMessage(string userName, string userSurname, double finalQuote)
    {
        Console.WriteLine($"Dear {userName} {userSurname},");
        Console.WriteLine($"Your insurance quote is: {finalQuote} euros");
    }

    static double GetGenderMultiplier()
    // Juozas Sadauskas
    {
        Console.WriteLine("Select gender: (1) Male, (2) Female");
        int genderChoice = int.Parse(Console.ReadLine());
        return (genderChoice == 1) ? 2.0 : 0.7;
    }

    static int GetAge()
    //Sarune Matiukaite
    {
        Console.WriteLine("Enter age:");
        return int.Parse(Console.ReadLine());
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
            Environment.Exit(0);
            return 0; // This line is never reached, but needed for the compiler
        }
    }

     static double GetHealthConditionMultiplier()
    {
        Console.WriteLine("Do you have existing health conditions? (y/n)");
        bool hasHealthCondition = Console.ReadLine().ToLower() == "y";
        return hasHealthCondition ? 1.5 : 1.0;
    }

    static double GetSmokingMultiplier()
    {
        Console.WriteLine("Do you smoke? (y/n)");
        bool isSmoker = Console.ReadLine().ToLower() == "y";
        return isSmoker ? 1.2 : -1.0;
    }

    static double CalculateQuote(double baseQuote, double genderMultiplier, double ageMultiplier, double healthConditionMultiplier, double smokingMultiplier)
    {
        return baseQuote * genderMultiplier * ageMultiplier * healthConditionMultiplier * smokingMultiplier;
    }
}



}