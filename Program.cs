using System;

class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        //LearningActivity31();
        //LearningActivity32();
        //LearningActivity33();
        //LearningActivity34();
        LearningActivity35();
    }

    static void LearningActivity31()
    {
        float celsius = 32;
        Console.WriteLine("Temperature is in Celsius: " + celsius);
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        Console.WriteLine("This is the function for Learning Activity 3.1!");
        Console.ReadKey();
    }

    static string[] names = new string[] { "Shea", "lucas", "Conyon", "Cat", "Camilo", "Emre", "Juliana", "Mason", "Bruno", "Keegan", "jose", "Muhammad", "Hoang", };
    static string[] wonders = new string[] { "The great wall of china", "The Taj Mahal", "Christ the Redeemer", "Machu Picchu", "The colosseum", "Chichen Itza", "Petra", };

    static void LearningActivity32()
    {
        Console.WriteLine("This is the names of my classmates");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine("This is the names of the 7 wonders of the world");
        for (int i = 0; i < wonders.Length; i++)
        {
            Console.WriteLine(wonders[i]);
        }
        Console.WriteLine("This is the function for Learning Activity 3.2!");
        Console.ReadKey();
    }
    static void LearningActivity33()
    {
        Console.WriteLine("This is the function for Learning Activity 3.3!");
    }

    static void LearningActivity34()
    {
        int number;
        bool success = int.TryParse(Console.ReadLine(), out number); //example code
        Console.WriteLine("This is the function for Learning Activity 3.4!");
    }

    static void LearningActivity35()
    {
        int[] highScores = { 1272700, 1271100, 1243000, 1218000, 1214300, 1210800, 1210400, 1206800, 1178400 };

        int averageScore = CalculatedAverage(highScores);
        double standardDeviation = CalculatedAverageDev(highScores, averageScore);

        Console.WriteLine("Average Rounded Score" + averageScore);
        Console.WriteLine("Average Deviation " + standardDeviation);
        Console.ReadKey();


        Console.WriteLine("This is the function for Learning Activity 3.5!");
    }

    public static int CalculatedAverage(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return (int)Math.Round((double)sum / scores.Length);
    }

    public static double CalculatedAverageDev(int[] scores, int mean)
    {
        double sumOfSquares = 0;
        foreach (int score in scores)
        {
            sumOfSquares += Math.Pow(score - mean, 2);

        }
        double variance = sumOfSquares / scores.Length;
        return Math.Sqrt(variance);
    }


}
