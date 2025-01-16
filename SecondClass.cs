namespace MissionTwo;

public class SecondClass
{
    public int[] SecondMethod(int num_rolls)
    {
        //Make random numbers
        Random rnd = new Random();
        int[] results = new int[11];
        
        for (int i = 0; i < num_rolls; i++)
        {
            int num1 = rnd.Next(1, 7);
            int num2 = rnd.Next(1, 7);
            
            //add the 2 random numbers together
            int roll_result = num1 + num2;
            results[roll_result - 2] += 1;
        }
        return results;
    }
}