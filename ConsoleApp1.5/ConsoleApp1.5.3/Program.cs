﻿using System;
using System.IO;

namespace App1
{
    class Program
    {
        public static void Main()
        {
            string path = @"numsTask3.txt";
            StreamReader readTask3 = new StreamReader(path);
            string[] numbers = readTask3.ReadLine().Split(' ');

            readTask3.Close();
            
            int[] nums = Array.ConvertAll(numbers, int.Parse);

            int minIndex = FindMinimumIndex(nums);
            float average = getSumBeforeIndex(nums, minIndex);

            Console.WriteLine($"Среднее арифметическое чисел до минимального: {average}");
        }
        
        private static int FindMinimumIndex(int[] array)
        {
            int minIndex = 0;
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }

            return minIndex;
        }

        private static int getSumBeforeIndex(int[] nums, int minIndex)
        {
            int result = 0;
            for (int i = 0; i < minIndex; i++)
            {
                result += nums[i];
            }

            return result;
        }
    }
}
