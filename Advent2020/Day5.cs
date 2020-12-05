using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent2020
{
    public class Day5
    {
        public static void Main(string[] args)
        {
            //  Part1();
            Part2();
        }

        public static void Part1()
        {
            List<string> seatnumbers = ReadFile();
            List<int> boarding_pass = new List<int>();
            String seat = "";

            foreach (var seatnumber in seatnumbers)
            {
                seat = seatnumber.Replace('F', '0').Replace('B', '1').Replace('L', '0').Replace('R', '1');
                boarding_pass.Add(Convert.ToInt32(seat, 2));
            }

            Console.WriteLine(boarding_pass.Max(x => x));

        }



        public static void Part2()
        {
            List<string> seatnumbers = ReadFile();
            List<int> boarding_pass = new List<int>();
            String seat = "";

            foreach (var seatnumber in seatnumbers)
            {
                seat = seatnumber.Replace('F', '0').Replace('B', '1').Replace('L', '0').Replace('R', '1');
                boarding_pass.Add(Convert.ToInt32(seat, 2));
            }

            var order = boarding_pass.OrderBy(x => x);
            var seatMe = Enumerable.Range(boarding_pass.Min(), boarding_pass.Count()).Except(boarding_pass).First();
            Console.WriteLine(seatMe);

        }

        public static List<string> ReadFile()
        {
            string line;
            List<string> seat = new List<string>();

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\Advent2020\Advent2020\Advent2020\input\InputDay5.txt");
            while ((line = file.ReadLine()) != null)
            {
                seat.Add(line);
            }

            file.Close();

            return seat;
        }
    }
}
