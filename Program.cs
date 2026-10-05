using System;

public class GalacticTravelAgency
{
    public static void Main(string[] args)
    {
        // Tasks 1-4: Creating Passenger Profiles
        string passengerName = "Zara";
        int passengerAge = 28;
        string ticketType = "First Class";
        string preferredPlanet = "Mars";

        // Tasks 5-8: Printing passenger data
        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAge);
        Console.WriteLine(ticketType);
        Console.WriteLine(preferredPlanet);

        // Task 9: Increment age by 1 and print
        passengerAge++;
        Console.WriteLine(passengerAge);

        // Task 10: Explicit conversion to double
        double passengerAgeDouble = (double)passengerAge;
        Console.WriteLine(passengerAgeDouble);

        // Task 11: Implicit conversion to double
        double passengerAgeDouble2 = passengerAge;
        Console.WriteLine(passengerAgeDouble2);

        // Task 12: Convert to string using Convert.ToString()
        string passengerAgeString = Convert.ToString(passengerAge);
        Console.WriteLine(passengerAgeString);
    }
}
