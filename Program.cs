// See https://aka.ms/new-console-template for more information

using MissionTwo;

internal class Program
{
    public static void Main(string[] args)
    {
        //welcome message and get roll number
        Console.WriteLine("Welcome to the dice throwing simulator! \n How many dice rolls would you like to simulate? ");
        int num_rolls = int.Parse(System.Console.ReadLine());
        
        //call the method of the second class to do calculations
        SecondClass sc = new SecondClass();
        int[] result = sc.SecondMethod(num_rolls);
        
        //calculate and print
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + num_rolls);
        int number = 2;
        int number2 = 0;
        for(int i = 0; i < result.Length; i++)
        {
            double starsCount = (result[number2] / (double)num_rolls) * 100;
            string stars = new string('*', Math.Max(1, (int)starsCount));
            Console.WriteLine(number + ": " + stars);
            number++; 
            number2++;
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    }
}

//get number of rolls
//store the number

//roll one die ande store the number
//roll the other die and store the number
//add the two numbers together
//update the tally that cooresponds to that number


//for each number
//calculate its percentage out of 100

//print the number 1-12
//for each percentage , display the asterisks