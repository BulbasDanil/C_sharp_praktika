using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveroyatnoNoPraktika.VacancyDir
{
    class Vacancy
    {
        public List<Compnay> Companies { get; set; } = new List<Compnay>();

        public List<string> Education { get; set; } = new List<string>() { "School", "One high", "Two high" };
        public List<string> Proffecion { get; set; } = new List<string>() { "Designer", "Coder", "Qa" };
        public List<string> Specialization { get; set; } = new List<string>() { "IOS", "Android", "Windows" };

        public void AddVacancy()
        {
            Compnay buf = new Compnay();

            Console.WriteLine("\nCreation of vacancy\n");
            Console.WriteLine("Enter the name of company");
            buf.Name = Console.ReadLine();

            Console.WriteLine("Enter the age");
            buf.Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gender");
            buf.Gender = Console.ReadLine();

            Console.WriteLine("Enter the number of education ( 1 - School, 2 - One higher, 3 - Two higher)");
            buf.Education = Int32.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Enter the number of profession ( 1 - Designer, 2 - Coder, 3 - Qa)");
            buf.Profession = Int32.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Enter the number of specialisation ( 1 - IOS, 2 - Android, 3 - Windows)");
            buf.Position = Int32.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Enter the amount of years on last position");
            buf.YearsOnLastPostion = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the overall amount of years on last position");
            buf.OverallYears = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the salary");
            buf.Salary = Double.Parse(Console.ReadLine());

            Companies.Add(buf);
        }

        public void DisplayAll()
        {
            foreach (Compnay p in Companies)
            {
                Console.WriteLine(p);
                Console.WriteLine($"Education: {Education[p.Education]}");
                Console.WriteLine($"Profession: {Proffecion[p.Profession]}");
                Console.WriteLine($"Specialization: {Specialization[p.Position]}");
            }
        }


        public void DelVacancy()
        {
            Console.WriteLine("\nDeletion of vacancy\n");
            try
            {
                DisplayAll();
                Console.WriteLine("Enter company name to delete");
                string buf = Console.ReadLine();

                var res = Companies.Single(u => u.Name == buf);
                Companies.Remove(res);
                Console.WriteLine("Удалено!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ShowVacancy()
        {
            Console.WriteLine("\nSearch of vacancy\n");
            try
            {
                DisplayAll();
                Console.WriteLine("Enter company name to delete");
                string buf = Console.ReadLine();

                var res = Companies.Single(u => u.Name == buf);
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
