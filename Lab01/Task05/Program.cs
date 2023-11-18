using System;

namespace Task05
{
    internal class Triangle 
    {
        internal float Perimetr { get; }
        internal Triangle(float perimetr)
        {
            Perimetr = perimetr;
        }

        internal float Side()
        {
            return Perimetr / 3;
        }
        internal float Sq() 
        {
            float side = this.Side();
            float halfperimetr = this.Perimetr / 2;
            float result = (float)Math.Sqrt(halfperimetr * Math.Pow(halfperimetr - side, 3));
            return result;
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите периметр треугольника: ");
            string info = Console.ReadLine();
            if (float.TryParse(info, out float perimetr))
            {
                Triangle ABC = new Triangle(perimetr);
                Console.WriteLine(
                    "Cторона\tРезультат\n"+
                    $"{ABC.Side():F}\t{ABC.Sq():F}"
                    );
            }
            else 
            {
                Console.WriteLine($"Не удалось преобразовать введенное значение \"{info}\" в числовые данные");    
            }

                
            Console.ReadLine();
        }
    }
}
