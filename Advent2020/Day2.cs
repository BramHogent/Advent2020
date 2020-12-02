using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent2020
{
    public static class Day2
    {
        public static void Main(string[] args)
        {
            Part1();
            Part2();

        }

        public static void Part1()
        {
            List<KeyValuePair<string, List<KeyValuePair<char, Tuple<int, int>>>>> passwords = ReadFile();
            int counter = 0;
            foreach (var pair in passwords)
            {
                var key = pair.Key;
                List<KeyValuePair<char, Tuple<int, int>>> test = pair.Value;

                if (Day2.Between(key.Count(x => x == test.First().Key), test.First().Value.Item1, test.First().Value.Item2))
                {

                    counter++;
                }


            }

            System.Console.WriteLine("Answer: " + counter);
        }

        public static void Part2()
        {
            List<KeyValuePair<string, List<KeyValuePair<char, Tuple<int, int>>>>> passwords = ReadFile();
            int counter = 0;
            foreach (var pair in passwords)
            {
                var key = pair.Key;
                List<KeyValuePair<char, Tuple<int, int>>> test = pair.Value;

                if (Day2.Position(key, test.First().Key,test.First().Value.Item1, test.First().Value.Item2))
                {

                    counter++;
                }


            }

            System.Console.WriteLine("Answer: " + counter);
        }

        public static List<KeyValuePair<string, List<KeyValuePair<char, Tuple<int, int>>>>> ReadFile()
        {

            string line;
            var map2 = new List<KeyValuePair<string, List<KeyValuePair<char, Tuple<int, int>>>>>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\Advent2020\Advent2020\Advent2020\input\InputDay2.txt");
            while ((line = file.ReadLine()) != null)
            {
                var map1 = new List<KeyValuePair<char, Tuple<int, int>>>();
                var input = line.Split(' ');
                var t = char.Parse(input[1].Trim(':'));

                map1.Add(new KeyValuePair<char, Tuple<int, int>>(t, new Tuple<int, int>(Int32.Parse(input[0].Split('-')[0]), Int32.Parse(input[0].Split('-')[1]))));
                map2.Add(new KeyValuePair<string, List<KeyValuePair<char, Tuple<int, int>>>>(input[2], map1));

            }

            file.Close();

            return map2;
        }

        public static bool Between(this int num, int lower, int upper, bool inclusive = false)
        {
            return inclusive
                ? lower <= num && num <= upper
                : lower <= num && num <= upper;
        }

        public static bool Position(this string input, char c, int lower, int upper)
        {

            return input[lower - 1] == c ^ input[upper - 1] == c;

        }
    }
}
