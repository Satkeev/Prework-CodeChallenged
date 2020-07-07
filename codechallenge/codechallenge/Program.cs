using System;

namespace preworkcodechallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 401 prework codechallenges!");
            Console.WriteLine(" ");

            // challenge 1  call method
            GameScore();

            // challenge 2 call method
            CalculLeapYear();

            // challenge 3 call method
            SequenceTest();

            // challenge 4 call method
            SumOfRows();

            Console.ReadLine();
        }
    }
}

private static void CalculScore(int[] choseArray, int choseNumber)
{

    // Number of times it occurs in the array
    int count = 0;
    foreach (int number in choseArray)
    {
        if (number == choseNumber)
        {
            count++;
        }
    }

    int score = count * choseNumber;

    //Console print your score
    Console.WriteLine($"Your score is {score}");
}

private static void GameScore()
{
    // in array get users number
    Console.WriteLine("Enter five numbers separated by commas (with no spaces in between)");

    string usersNumber = Console.ReadLine();

    // Selected array of five numbers print to console
    Console.WriteLine($"Selected numbers: {usersNumber}");

    // arrray of five numbers
    string[] stringArray = usersNumber.Split(",");
    // Console.WriteLine($"stringArray: {stringArray}");

    int[] arrayinNumbers = new int[5];

    arrayinNumbers[0] = int.Parse(stringArray[0]);
    arrayinNumbers[1] = int.Parse(stringArray[1]);
    arrayinNumbers[2] = int.Parse(stringArray[2]);
    arrayinNumbers[3] = int.Parse(stringArray[3]);
    arrayinNumbers[4] = int.Parse(stringArray[4]);

    //Select a number from the array
    Console.WriteLine("Enter one number from among the five numbers you entered.");
    int numberChoice = int.Parse(Console.ReadLine());

    CalculScore(arrayinNumbers, numberChoice);

    Console.WriteLine(" ");
}




private static void CalculLeapYear()
{
    Console.WriteLine("Enter a year to see if it's a leap year.");

    string userPrompt = Console.ReadLine();

    int userPromptToInt = int.Parse(userPrompt);

    if (userPromptToInt % 4 == 0)
    {
        if (userPromptToInt % 100 == 0)
        {
            if (userPromptToInt % 400 == 0)
            {
                Console.WriteLine("Year you entered is a leap year!");
            }
            else
            {
                Console.WriteLine("Year you entered no a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Year you entered is a leap year!");
        }
    }
    else
    {
        Console.WriteLine("Year you entered no a leap year.");
    }
    Console.WriteLine(" ");
}



private static void SequenceTest()
{
    Console.WriteLine("Please enter a list of non-negative integers to see if they are a perfect sequence " +
        "(The numbers must be separated by commas with no spaces in between)");

    // input by user
    string inputUser = Console.ReadLine();

    // User input turn into a string array
    string[] stringArray = inputUser.Split(",");

    // Empty integer array of length of users string array
    int[] intArray = new int[stringArray.Length];

    // Populate integer array with numbers from user's string array (after converting them from strings to ints)
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = int.Parse(stringArray[i]);
    }

    // Set counters
    int prodOfElements = 1;
    int sumOfElements = 0;

    // Calculate product and sum of array elements
    for (int i = 0; i < intArray.Length; i++)
    {
        prodOfElements *= intArray[i];
        sumOfElements += intArray[i];
    }

    // Test for perfect sequence
    if (prodOfElements == sumOfElements)
    {
        Console.WriteLine("The numbers you entered are a perfect sequence!");
    }
    else
    {
        Console.WriteLine("The numbers you entered are not a perfect sequence.");
    }

    Console.WriteLine(" ");
}



private static void SumOfRows()
{
    Console.WriteLine("Create a multidimensional array and sum rows");

    // number for m  dimension of matrix from users
    Console.WriteLine("Please enter a positive integer for the number of rows you want in the array");
    string mDimenAsString = Console.ReadLine();
    int mDimenAsInt = int.Parse(mDimenAsString);
    Console.WriteLine($"Thanks! You entered {mDimenAsInt}");
    Console.WriteLine($" ");

    // number for n  dimension of matrix from users
    Console.WriteLine("Enter a positive integer for the number of columns you want in the array.");
    string nDimenAsString = Console.ReadLine();
    int nDimenAsInt = int.Parse(nDimenAsString);
    Console.WriteLine($"Thanks! You entered {nDimenAsInt}");
    Console.WriteLine($" ");

    // Empty array based on dimensions input by users
    int[,] userArray = new int[mDimenAsInt, nDimenAsInt];

    // Populate matrix with random numbers
    Random newRandNum = new Random();
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            userArray[i, j] = newRandNum.Next(1, 100);
        }
    }

    sumRows(userArray);
}

// Helper function that takes array as param and sums row(s)
private static void sumRows(int[,] array)
{
    // Empty array to hold row totals
    int[] rowTotalArray = new int[array.GetLength(0)];

    // Sum elements in each row
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int total = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            total += array[i, j];
        }

        // Add row total as new element in array of row totals
        rowTotalArray[i] = total;
    }
    Console.WriteLine($"Sums of the elements in each row of the multidimensional array:");
    Console.WriteLine("[{0}]", string.Join(",", rowTotalArray));
}
    