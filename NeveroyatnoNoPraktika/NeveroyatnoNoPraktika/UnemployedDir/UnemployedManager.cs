using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NeveroyatnoNoPraktika.UnemployedDir
{
    class UnemployedManager
    {
        public List<Unemployed> Unemployeds { get; set; } = new List<Unemployed>();

        public List<string> Education { get; set; } = new List<string>() { "School", "One higher", "Two higher" };
        public List<string> Proffecion { get; set; } = new List<string>() { "Designer", "Coder", "Qa" };
        public List<string> Specialization { get; set; } = new List<string>() { "IOS", "Android", "Windows" };

        public void AddUnemployed()
        {
            Unemployed buf = new Unemployed();

            Console.WriteLine("\nCreation of unemployed\n");
            Console.WriteLine("Enter the surname");
            buf.Surname = Console.ReadLine();

            Console.WriteLine("Enter the age");
            buf.Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gender");
            buf.Gender = Console.ReadLine();

            Console.WriteLine("Enter the number of education ( 1 - School, 2 - One higher, 3 - Two higher)");
            buf.Education = Int32.Parse(Console.ReadLine())-1;

            Console.WriteLine("Enter the number of profession ( 1 - Designer, 2 - Coder, 3 - Qa)");
            buf.Profession = Int32.Parse(Console.ReadLine())-1;

            Console.WriteLine("Enter the number of specialisation ( 1 - IOS, 2 - Android, 3 - Windows)");
            buf.Position = Int32.Parse(Console.ReadLine())-1;

            Console.WriteLine("Enter the amount of years on last position");
            buf.YearsOnLastPostion = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the overall amount of years on last position");
            buf.OverallYears = Int32.Parse(Console.ReadLine());

            Date dbuff = new Date();

            Console.WriteLine("Enter the day of opening position");
            dbuff.Day = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of opening position (number)");
            dbuff.Month = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year of opening position");
            dbuff.Year = UInt32.Parse(Console.ReadLine());

            buf.Date = dbuff;

            Console.WriteLine("Enter the salary");
            buf.Salary = Double.Parse(Console.ReadLine());

            Unemployeds.Add(buf);
        }

        public void DisplayAll()
        {
            foreach (Unemployed u in Unemployeds)
            {
                Console.WriteLine(u);
                Console.WriteLine($"Education: {Education[u.Education]}");
                Console.WriteLine($"Profession: {Proffecion[u.Profession]}");
                Console.WriteLine($"Specialization: {Specialization[u.Position]}");
            }
        }

        public void DelUnemployed()
        {
            Console.WriteLine("\nDeletion of unemployed\n");
            try
            {
                DisplayAll();
                Console.WriteLine("Enter surname to delete");
                string buf = Console.ReadLine();

                var res = Unemployeds.Single(u => u.Surname == buf);
                Unemployeds.Remove(res);
                Console.WriteLine("Удалено!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void SearchUnemployed()
        {
            Console.WriteLine("\nSearching for unemployed\n");
            try
            {
                DisplayAll();
                Console.WriteLine("Enter surname to find");
                string buf = Console.ReadLine();

                var res = Unemployeds.Single(u => u.Surname == buf);
                Console.WriteLine(res);
                Console.WriteLine($"Education: {Education[res.Education]}");
                Console.WriteLine($"Profession: {Proffecion[res.Profession]}");
                Console.WriteLine($"Specialization: {Specialization[res.Position]}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
