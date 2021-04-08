using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите заработные платы: минимальную, среднюю, высокую:");

            int minimalPay = int.Parse(Console.ReadLine());
            int midPay = int.Parse(Console.ReadLine());
            int hightPay = int.Parse(Console.ReadLine());

            int difference = minimalPay + midPay + hightPay;

            difference = hightPay - minimalPay;

            Console.WriteLine("Разница между минимальной и высокой зарплатой:");

            Console.WriteLine(difference);

            Console.ReadKey();         
        }
    }
}
