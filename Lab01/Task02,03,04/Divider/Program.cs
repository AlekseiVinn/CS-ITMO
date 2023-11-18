using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое целое число: ");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.Write("Введите второе целое число: ");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine($"Результат деления {i} на {j}: {k}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("An exception was thrown: {0}.", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}.", e.Message);
            }
        }
    }
}
