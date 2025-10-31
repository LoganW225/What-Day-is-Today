using System;

class Program
{
    static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter a number between 1 and 7 representing the day of the week ");
        int day = Convert.ToInt32(Console.ReadLine());

        // Useing switch statement to display message
        switch (day)
        {
            case 1:
                Console.WriteLine("Aack! I hate Mondays!");
                break;

            case 2:
                Console.WriteLine("It's Tuesday!");
                break;

            case 3:
                Console.WriteLine("Hump Daaaay!");
                break;

            case 4:
                Console.WriteLine("It's Thursday!");
                break;

            case 5:
                Console.WriteLine("TGIF!");
                break;

            case 6:
            case 7:
                Console.WriteLine("It's the weekend!");
                break;

            default:
                Console.WriteLine("That’s not a valid day number! Please enter a number between 1 and 7.");
                break;
        }
    }
}