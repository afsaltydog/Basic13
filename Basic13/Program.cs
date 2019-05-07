using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] nums = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
            LoopArray(nums);
            Console.WriteLine(FindMax(nums));
            GetAverage(nums);
            LoopArray(OddArray());
            Console.WriteLine(" the numbers GreaterThanY are: " + GreaterThanY(nums, 6));
            SquareArrayValues(nums);
            int[] newNums = { 1, 5, 10, -2 };
            EliminateNegatives(newNums);
            int[] nNums = { 1, 5, 10, -2 };
            MinMaxAverage(nNums);
            Console.WriteLine("ShiftValues([1, 5, 10, -2]): ");
            ShiftValues(nNums);
            int[] arr = { -1, -3, 2 };
            LoopArray(NumToString(arr));
        }
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey(true);
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey(true);
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
    
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3

            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
            Console.ReadKey(true);
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey(true);
        }
        public static void LoopArray(object[] objs)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 

            foreach (object o in objs)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey(true);
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("The max value is "+max);
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The AVERAGE of the values is " + sum / numbers.Length);
            Console.ReadKey(true);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].

            List<int> oddArr = new List<int>();

            for (int i = 1; i < 256; i++)
            {
                if (i%2 != 0)
                {
                    oddArr.Add(i);
                }
            }

            return oddArr.ToArray();
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value.
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                    sum++;
            }

            return sum;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }

            Console.WriteLine("SquareArrayValues:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey(true);
        }
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

            Console.WriteLine("EliminateNegatives");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey(true);
        }
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.

            int sum = numbers[0];
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
                sum += numbers[i];
            }

            Console.WriteLine("The Min is {0}, the Max is {1}, and the Average is {2}", min, max, sum / numbers.Length);
            Console.ReadKey(true);
        }
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].

            int temp = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            numbers[numbers.Length - 1] = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey(true);
        }
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].

            Console.WriteLine("NumToString");

            List<object> Dojo = new List<object>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    Dojo.Add("Dojo");
                else
                    Dojo.Add(numbers[i]);
            }

            for (int i = 0; i < Dojo.Count; i++)
            {
                Console.WriteLine(Dojo[i]);
            }
            
            Console.ReadKey(true);

            return Dojo.ToArray();
        }
    }
}
