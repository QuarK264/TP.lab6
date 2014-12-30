namespace DAA.TP.lab6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static double GetValue(string msg)
        {
            double x;
            do
            {
                Console.Write(msg);
                string str = Console.ReadLine();
                if (double.TryParse(str, out x))
                {
                    return double.Parse(str);
                }
                Console.WriteLine("Входная строка имеет не верный формат.");
            }
            while (true);
        }

        static void FirstSystemHandler(double x)
        {
            if (x >= 0)
            {
                Console.WriteLine("Результат первой системы для x >= 0: {0}", Math.Cos(4 * x));
            }
            else
            {
                double func = Math.Pow(Math.Pow(x, 8) - Math.Pow(x, 7) + 7, 9);
                if (double.IsInfinity(func))
                {
                    Console.WriteLine("Результат расчёта первой системы для x < 0 - бесконечно большая функция");
                }
                else
                {
                    Console.WriteLine("Результат расчёта первой системы для x < 0: {0}", func);
                }
            }
        }

        static void SecondSystemHandler(double x)
        {
            if (x >= 4)
            {
                double func = Math.Sqrt(Math.Pow(x, 2) - 16);
                if (double.IsInfinity(func))
                {
                    Console.WriteLine("Результат расчёта второй системы для x >= 4 - бесконечно малая функция");
                }
                else
                {
                    Console.WriteLine("Результат расчёта второй системы для x >= 4: {0}", func);
                }
            }
            else
            {
                Console.WriteLine("Результат расчёта второй системы для x < 4: {0}", Math.Sin(7 * x + 2));
            }
        }

        static void Main()
        {
            double x = GetValue("Введите x:");
            Systems syst = new Systems();
            syst.CountSystem += FirstSystemHandler;
            syst.CountSystem += SecondSystemHandler;
            syst.CountingSystem(x);

            Console.ReadKey();
        }
    }
}
