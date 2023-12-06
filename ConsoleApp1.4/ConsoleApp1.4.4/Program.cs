﻿using System;

namespace App4
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\Users\gr622_nemol\Desktop\practica\ConsoleApp1.4\ConsoleApp1.4.4\bin\Debug\net7.0\numsTask4.txt";
            string[] lines = File.ReadAllLines(path);

            int count = 0;

            foreach (string line in lines)
            {
                string[] numbers = line.Split(' ');
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {count}");
        }
    }
}
