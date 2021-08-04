using System;

namespace NumberAverage
{
    public class NumberAverage
    {
        static void Main(string[] args)
        {
            // get size of array
            Console.Write("Enter the number of values");
            int val = Convert.ToInt32(Console.ReadLine());
            // declare array for the given size
            int[] number = new int[val];
            //get the values of the array from the user
            for (int i = 0; i < val; i++)
            {
                Console.Write("Enter the value::::");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            //call FindAverage() method to calculate average and receive string response
            String result = FindAverage(number);
            //print the result
            Console.WriteLine(result);
            Console.ReadLine();
        }
        //write here logic to calculate the average an array
        public static String FindAverage(int[] number)
        {
            int sum = 0, result;
            if (number.Length == 0)
            {
                return "Array is Empty";
            }
            foreach (int value in number)
            {
                if (value < 0)
                {
                    return "Negative values in array";
                }
                sum = sum + value;
            }
            result = sum / number.Length;
            return "The Average is: " + result;
        }
    }
}
