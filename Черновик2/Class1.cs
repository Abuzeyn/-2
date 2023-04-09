using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Черновик2
{
    public static class Class1
    {
        public static double ReadFromConsoleSum()
        {
            Console.WriteLine("Введите сумму вклада");
            double sum = Convert.ToDouble(Console.ReadLine());
            return sum;
        }

        public static double ReadFromConsoleDepositPeriod()
        {
            Console.WriteLine("Срок хранения вклада в годах");
            double depositPeriod = Convert.ToDouble(Console.ReadLine());
            return depositPeriod;

        }

        public static double ReadFromConsolePerсentYear()
        {
            Console.WriteLine("Процент начисляемый за год");
            double percentYear = Convert.ToDouble(Console.ReadLine());
            return percentYear;
        }

        public static void CalculatorEndAnswer(double sum, double depositPeriod, double percentYear)
        {
            double a = (percentYear + 100) / 100;
            for (double i = 1; i <= depositPeriod; i++)
            {
                sum = sum * a;

            }
            Console.WriteLine(sum);


        }



    }
}
