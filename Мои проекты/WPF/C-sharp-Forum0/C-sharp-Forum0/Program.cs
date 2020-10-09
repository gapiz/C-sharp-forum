using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Forum0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой год рождения: ");
            int dateOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Введите текущий год: ");
            int nowYear = int.Parse(Console.ReadLine());
            int age = nowYear - dateOfBirth;
            Console.Write("Ваш возраст: "+age);
            Console.ReadKey();
        }
    }
}
