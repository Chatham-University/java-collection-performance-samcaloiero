using System;
//
// public class ArrayDemo
// {
//     private int[] nums;
//
//     public ArrayDemo(int howManyNums, Random rand)
//     {
//         nums = new int[howManyNums];
//         for (int i = 0; i < howManyNums; i++)
//         {
//             nums[i] = rand.Next(howManyNums);
//         }
//
//         Console.WriteLine("The first few numbers are:");
//         for (int i = 0; i < Math.Min(6, nums.Length); i++)
//         {
//             Console.WriteLine(nums[i]);
//         }
//     }
// }

// // Entry point of the application
// class Program
// {
//     static void Main()
//     {
//         Random rand = new Random();
//         ArrayDemo demo = new ArrayDemo(10, rand);
//     }
// }

namespace CollectionsTest
{
    public class VectorDemo
    {
        //vector<integer> not commonly used
        private readonly List<int> nums;

        public VectorDemo(int howManyNums, Random rand)
        {
            nums = new List<int>();
            for (int i = 0; i < howManyNums; i++)
            {
                //literally had to capitalize the a in Add
                nums.Add(rand.Next(howManyNums));
            }

            Console.WriteLine("The first few numbers are:");
            for (int i = 0; i < Math.Min(6, nums.Count); i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
    public class LinkedListDemo 
    {
        private readonly LinkedList<int> nums;

        public LinkedListDemo(int howManyNums, Random rand)
        {
            nums = new LinkedList<int>();
            for (int i = 0; i < howManyNums; i++)
            {
                nums.AddLast(rand.Next(howManyNums));
            }

            Console.WriteLine("The first few numbers are:");
            var node = nums.First;
            for (int i = 0; i < Math.Min(6, nums.Count) && node != null; i++)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    } 
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
    class Program
    {
        public static int HOW_MANY_NUMS = (int)Math.Pow(10, 6);
        // static void Main()
        // {
        //     Random rand = new Random();
        //     ArrayDemo demo = new ArrayDemo(10, rand);
        //     LinkedListDemo linkedListDemo = new LinkedListDemo(10, rand);
        //     
        // }
        public static void Main()
        { 
       
            // Make a new random number generator for us to use.
            // Using a fixed seed for reproducibility (not recommended in real applications)
            Random rand = new Random(556401139);

            var start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            new ArrayDemo(HOW_MANY_NUMS, rand);
            long end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine($"Array Time: {(end - start) / 1000.0:F3} seconds");

            start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            new VectorDemo(HOW_MANY_NUMS, rand);
            end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine($"Vector Time: {(end - start) / 1000.0:F3} seconds");

            start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            new LinkedListDemo(HOW_MANY_NUMS, rand);
            end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine($"LinkedList Time: {(end - start) / 1000.0:F3} seconds");
        }
    }
}