using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get details for Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            string hourlyRate1 = Console.ReadLine();
            Console.Write("Hours worked per week? ");
            string hoursWorkedPerWeek1 = Console.ReadLine();

            // Get details for Person 2
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate? ");
            string hourlyRate2 = Console.ReadLine();
            Console.Write("Hours worked per week? ");
            string hoursWorkedPerWeek2 = Console.ReadLine();

            // Convert input strings to numeric values
            double rate1 = Convert.ToDouble(hourlyRate1);
            double hours1 = Convert.ToDouble(hoursWorkedPerWeek1);
            double rate2 = Convert.ToDouble(hourlyRate2);
            double hours2 = Convert.ToDouble(hoursWorkedPerWeek2);

            // Calculate annual salaries
            double salary1 = rate1 * hours1 * 52;
            double salary2 = rate2 * hours2 * 52;

            // Print annual salaries
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1.ToString("N0")); // "N0" adds thousands separators
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2.ToString("N0"));

            // Check if Person 1 makes more money than Person 2
            bool person1MakesMore = salary1 > salary2;

            // Print the comparison result
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1MakesMore);

        }
    }
}
