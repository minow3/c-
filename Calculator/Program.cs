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
        Console.Clear();
        AdminInterface(agent);


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

    }

    static void PasswordManager()
    {   
        while (true)
        {
            int agentPass = 1234;   // Agent password
            int agentProvidedPass = Convert.ToInt32(Console.ReadLine());

            if (agentProvidedPass == agentPass)
            {
                break;
            }
            else if(agentProvidedPass != agentPass)
            {
                Console.Clear();
                Clock();
                Console.WriteLine("\n\n\tMoneyBag Insurance Group LTD");
                Console.WriteLine("\n\tInvalid code");
                Console.WriteLine("\n\tProvide correct authentication code");
            }
            
        }
        
    }

    static void AgentAge(int userAge)
    {
        if (userAge < 35) {
            Console.Write("20% extra under 35");
            count += 20;
        }
        else if (userAge > 35 &&  userAge < 55)
        {
            Console.Write("40% extra from 35 to 55 inclusive");
            count += 40;
        }
            else if (userAge > 56 && userAge < 70) 
        {
            Console.Write("65% etra from 56 to 70");
            count += 65;
        }
            else if (userAge > 70) {
            Console.Write("No quote provided for over 70");
        }
            else 
        {
            Console.Write("incorrect age");
        }

        if (userAge < 35 == count) {
            if (userAge == count) {
                Console.Write("20% added");
            }
            else if (userAge > 35 && userAge < 55)
                if (userAge == count) {
                    Console.Write("40% extra");
            }
            else if (userAge > 56 && userAge < 70)
                if (userAge == count) {
                    Console.Write("65% extra");
                    break;
            }
            Console.Write("Do you want to play again (y/n)");
            tryAgain = Console.ReadLine();
            if (tryAgain == "y")
            {
                int newQuote;
            }
            else if (tryAgain == "n")
            {
                gamePlay = false;
            }
        }
    }


}