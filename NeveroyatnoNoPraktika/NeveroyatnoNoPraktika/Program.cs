using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeveroyatnoNoPraktika.UnemployedDir;
using NeveroyatnoNoPraktika.VacancyDir;

namespace NeveroyatnoNoPraktika
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            UnemployedManager um = new UnemployedManager();

            Console.WriteLine("\n\nUnemployed manager test\n");
            um.AddUnemployed(); // добавить нового безработного
            um.DisplayAll(); // вывод всех

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            um.DelUnemployed(); // удалить безработного
            um.DisplayAll(); // вывод всех

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            um.AddUnemployed(); // добавить нового безработного
            um.AddUnemployed(); // добавить нового безработного
            um.SearchUnemployed(); //вывод только заданого пользователем

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //2
            Vacancy vm = new Vacancy(); //менеджер управления свободными вакансиями

            Console.Clear();
            Console.WriteLine("\n\n Vacancy manager test\n");
            vm.AddVacancy(); // добавление вакансии
            vm.DisplayAll(); //вывод всех

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            vm.DelVacancy(); // удаление заданой вакансии
            vm.DisplayAll(); //вывод всех

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            vm.AddVacancy(); // добавление вакансии
            vm.AddVacancy(); // добавление вакансии
            vm.ShowVacancy(); //вывод заданой вакансии

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
