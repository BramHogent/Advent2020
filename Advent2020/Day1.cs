using System;
using System.Collections.Generic;

namespace Advent2020
{
    public class Day1
    {
        public static void Main(string[] args)
        {
          //  Part1();
            Part2();
        }

        public static void Part1()
        {
            List<int> numbers = ReadFile();
            int n = numbers.Count;
            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = (i + 1); j < n; j++)
                {
                    if (numbers[i] + numbers[j] == 2020)
                    {
                        System.Console.WriteLine(numbers[i].ToString() + " " + numbers[j].ToString());
                        System.Console.WriteLine("Anwser = " + numbers[i] * numbers[j]);
                    }

                }
            }
        }

        public static void Part2()
        {
            List<int> numbers = ReadFile();
            int n = numbers.Count;
            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = (i + 1); j < n; j++)
                {
                    for (int z = (i + 1); z < n; z++)
                    {
                        if (numbers[i] + numbers[j] + numbers[z] == 2020)
                        {
                            System.Console.WriteLine(numbers[i].ToString() + " " + numbers[j].ToString()+ " " +  numbers[z].ToString());
                            System.Console.WriteLine("Anwser = " + (numbers[i] * numbers[j] * numbers[z]));
                            
                        }

                    }
                }
            }
        }
        public static List<int> ReadFile()
        {
            int counter = 0;
            string line;
            List<int> numbers = new List<int>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\Advent2020\Advent2020\Advent2020\input\InputDay1.txt");
            while ((line = file.ReadLine()) != null)
            {
                numbers.Add(Int32.Parse(line));
                counter++;
            }

            file.Close();

            return numbers;
        }
    }
}
