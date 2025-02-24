using System;

public class ArrayDemo
{
    private int[] nums;

    public ArrayDemo(int howManyNums, Random rand)
    {
        nums = new int[howManyNums];
        for (int i = 0; i < howManyNums; i++)
        {
            nums[i] = rand.Next(howManyNums);
        }

        Console.WriteLine("The first few numbers are:");
        for (int i = 0; i < Math.Min(6, nums.Length); i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}

// Entry point of the application
class Program
{
    static void Main()
    {
        Random rand = new Random();
        ArrayDemo demo = new ArrayDemo(10, rand);
    }
}