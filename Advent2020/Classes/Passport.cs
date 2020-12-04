using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2020.Classes
{
    public class Passport
    {
        public string byr { get; set; }
        public string iyr { get; set; }
        public string eyr { get; set; }
        public string hgt { get; set; }
        public string hcl { get; set; }
        public string ecl { get; set; }
        public string pid { get; set; }
        public string cid { get; set; }

        public Passport(string Byr, string Iyr, string Eyr, string Hgt, string Hcl, string Ecl, string Pid, string Cid)
        {
            byr = Byr;
            iyr = Iyr;
            eyr = Eyr;
            hgt = Hgt;
            hcl = Hcl;
            ecl = Ecl;
            pid = Pid;
            cid = Cid;
        }
        public Passport()
        {
            byr = null;
            iyr = null;
            eyr = null;
            hgt = null;
            hcl = null;
            ecl = null;
            pid = null;
            cid = "0";
        }

        
    }
}
