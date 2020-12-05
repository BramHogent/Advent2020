using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Advent2020.Classes;
namespace Advent2020
{
    public static class Day4
    {

        public static void Main(string[] args)
        {
            Part1();
            Part2();
        }

        public static void Part1()
        {
            List<Passport> passports = ReadFile();
            Console.WriteLine(passports.Count + 1);
        }
        public static void Part2()
        {
            List<Passport> passports = ReadFile2();
            Console.WriteLine(passports.Count);
        }
        public static List<Passport> ReadFile()
        {

            string line;
            List<Passport> passports = new List<Passport>();
            Passport passport = new Passport();
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\Advent2020\Advent2020\Advent2020\input\InputDay4.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line == string.Empty)
                {

                    if (HasProperties(passport))
                    {

                        passports.Add(passport);
                    }
                    passport = new Passport();
                }
                else
                {
                    var cidx = line.IndexOf(':');

                    var input = line.Split(' ');
                    foreach (var item in input)
                    {
                        var t = item.Trim(':');
                        var name = t.Substring(0, cidx).Trim();
                        var value = t.Substring(cidx + 1).Trim();

                        switch (name)
                        {
                            case "byr":
                                passport.byr = value;
                                break;
                            case "iyr":
                                passport.iyr = value;
                                break;
                            case "eyr":
                                passport.eyr = value;
                                break;
                            case "hgt":
                                passport.hgt = value;
                                break;
                            case "hcl":
                                passport.hcl = value;
                                break;
                            case "ecl":
                                passport.ecl = value;
                                break;
                            case "pid":
                                passport.pid = value;
                                break;
                            case "cid":
                                passport.cid = value;
                                break;

                        }
                    }



                }


            }

            file.Close();
           
            return passports;
        }
        public static List<Passport> ReadFile2()
        {

            string line;
            List<Passport> passports = new List<Passport>();
            Passport passport = new Passport();
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\Advent2020\Advent2020\Advent2020\input\InputDay4.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line == string.Empty)
                {

                    if (HasProperties(passport))
                    {

                        passports.Add(passport);
                    }
                    passport = new Passport();
                }
                else
                {
                    var cidx = line.IndexOf(':');

                    var input = line.Split(' ');
                    foreach (var item in input)
                    {
                        var t = item.Trim(':');
                        var name = t.Substring(0, cidx).Trim();
                        var value = t.Substring(cidx + 1).Trim();

                        switch (name)
                        {
                            case "byr":
                            
                                if (Int32.Parse(value) >=1920  && Int32.Parse(value) <=2002)
                                {
                                    passport.byr = value;
                                }
                                break;
                            case "iyr":
                                if (Int32.Parse(value) >= 2010 && Int32.Parse(value) <= 2020)
                                {
                                    passport.iyr = value;
                                }
                                break;
                            case "eyr":
                                if (Int32.Parse(value) >= 2020 && Int32.Parse(value) <= 2030)
                                {
                                    passport.eyr = value;
                                }
                                break;
                            case "hgt":
                                if (value.EndsWith("cm"))
                                {
                                    var height = int.Parse(value.Substring(0, value.Length - 2));
                                    if (Enumerable.Range(150, 193).Contains(height))
                                    {
                                        passport.hgt = value;
                                    }

                                }
                                else if (value.EndsWith("in"))
                                {
                                    var height = int.Parse(value.Substring(0, value.Length - 2));
                                    if (Enumerable.Range(59, 76).Contains(height))
                                    {
                                        passport.hgt = value;
                                    }
                                }
                                else
                                {

                                }
                                break;
                            case "hcl":

                                var hclregex = new Regex("#[a-f0-9]{6}");
                                if (hclregex.IsMatch(value))
                                {

                                    passport.hcl = value.Replace("#", ""); ;
                                }
                                break;
                            case "ecl":
                                var colors = new List<String>() { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                                if (colors.Contains(value))
                                {
                                    passport.ecl = value;
                                }
                                break;
                            case "pid":
                                var pidregex = new Regex("[0-9]{9}");
                                if (pidregex.IsMatch(value))
                                {
                                    passport.pid = value;
                                }

                                break;
                            case "cid":
                                passport.cid = value;
                                break;

                        }
                    }
                }



            }




            file.Close();
            return passports;
        }
        public static bool HasProperties(this object obj)
        {

            return obj.GetType().GetProperties()
                            .All(p => p.GetValue(obj) != null);

        }
    }
}
