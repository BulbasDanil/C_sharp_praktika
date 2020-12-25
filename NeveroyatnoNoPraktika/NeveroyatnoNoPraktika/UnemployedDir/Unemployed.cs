using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveroyatnoNoPraktika.UnemployedDir
{
    class Unemployed
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Education { get; set; }
        public int Profession { get; set; }
        public int Position { get; set; }
        public int YearsOnLastPostion { get; set; }
        public int OverallYears { get; set; }
        public Date Date { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Surname,15} {Age,15} {Gender,15} {YearsOnLastPostion,15} {OverallYears,15} {Date,15} {Salary,15}";
        }
    }
}
