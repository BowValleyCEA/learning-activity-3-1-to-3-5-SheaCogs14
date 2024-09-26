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
        char[,] board = new char[3, 3]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        char currentPlayer = 'X';
        bool gameWon = false;
        bool gameDraw = false;

        while (!gameWon && !gameDraw)
        {
            DisplayBoard(board);
            PlayerMove(board, currentPlayer);
            gameWon = CheckWin(board, currentPlayer);
            gameDraw = CheckDraw(board);

            if (gameWon)
            {
                DisplayBoard(board);
                Console.WriteLine($"Player {currentPlayer} wins!");
            }
            else if (gameDraw)
            {
                DisplayBoard(board);
                Console.WriteLine("The game is a draw!");
            }
            else
            {
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }
        Console.ReadKey();
    }

    static void DisplayBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("-----");
        }
    }

    static void PlayerMove(char[,] board, char player)
    {
        int move;
        bool validMove = false;
        do
        {
            Console.WriteLine($"Player {player}, enter your move (1-9):");
            move = int.Parse(Console.ReadLine()) - 1;
            int row = move / 3;
            int col = move % 3;
            if (board[row, col] != 'X' && board[row, col] != 'O')
            {
                board[row, col] = player;
                validMove = true;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

        } while (!validMove);
    }

    static bool CheckWin(char[,] board, char player)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                (board[0, i] == player && board[1, i] == player && board[2, i] == player))
                return true;
        }
        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
            return true;

        return false;
    }

    static bool CheckDraw(char[,] board)
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
            {
                return false;
            }
        }
        return true;
    }



    static void LearningActivity34()
    {
        int age;
        bool isValid;

        do
        {
            Console.WriteLine("Please enter your age!");
            string input = Console.ReadLine();

            isValid = int.TryParse(input, out age);
            if (isValid && age > 10 && age < 50)
            {
                Console.WriteLine("Thank you!");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
            }
        } while (true);
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

     static int CalculatedAverage(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return (int)Math.Round((double)sum / scores.Length);
    }

     static double CalculatedAverageDev(int[] scores, int mean)
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