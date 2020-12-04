using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent2020
{
    public static class Day3
    {

        public static void Main(string[] args)
        {
            //Part1();
            Part2();

        }

        public static void Part1()
        {
            int output = Ski(ReadFiles(), 3, 1);

            Console.WriteLine(output);
        }

        public static void Part2()
        {
            List<int> trees = new List<int>();
            double output = 1;
            List<Slope> slopes = new List<Slope>()
            
        {
            new Slope(){ X=1, Y=1},
            new Slope(){ X=3, Y=1},
            new Slope(){ X=5, Y=1},
            new Slope(){ X=7, Y=1},
            new Slope(){ X=1, Y=2}
        };

            foreach (Slope slope in slopes)
            {
                trees.Add(Ski(ReadFiles(), slope.X, slope.Y));
            }

            for (int i = 0; i < trees.Count; i++)
            {
                
                output = output * trees[i]; 
            }
            Console.WriteLine(output);
        }

        private static int Ski(List<string> input, int xGrow, int yGrow)
        {
            int trees = 0;
            int widthOfMap = input[0].Length;
            int heightOfMap = input.Count;
            int y = 0;
            int x = 0;
            while (y != heightOfMap - 1)
            {
                y += yGrow;
                x += xGrow;
                if (x >= widthOfMap)
                {
                    x = x - widthOfMap;
                }
                char mapField = input[y][x];
                if (mapField.ToString() == "#")
                {
                    trees++;
                }
            }

            return trees;
        }

        public static List<string> ReadFiles()
        {

            string line;
            List<string> numbers = new List<string>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\Advent2020\Advent2020\Advent2020\input\InputDay3.txt");
            while ((line = file.ReadLine()) != null)
            {
                numbers.Add(line);

            }

            file.Close();

            return numbers;
        }

        public class Slope
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }



}
