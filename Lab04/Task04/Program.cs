using System.Xml.Serialization;

namespace Task04
{
    internal class Operation
    {
        public static void Choice()
        {
            Console.Write("Равносторонний треугольник? y/n: ");
            try
            {
                string test = Console.ReadLine();
                if (test == "y" || test == "Y")
                {
                    int side = SetSide();
                    Sq(side);
                }
                else if (test == "n" || test == "N")
                {
                    int side1 = SetSide();
                    int side2 = SetSide();
                    int side3 = SetSide();
                    Sq(side1, side2, side3);
                }
                else
                { 
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("введено неверное значение");
                Choice();
            }
          
        }

        static int SetSide()
        {
            Console.Write("\nВведите строну треугольника: ");
            int side = int.Parse(Console.ReadLine());
            return side;
        }
        
        private static bool IsTriangle(params int[] side)
        {
            float halfperimetr = checked((float)(side[0] + side[1] + side[2])) / 2;
            foreach (int i in side)
            {
                if (i >= halfperimetr) return false;

            }
            return true;
        }

        static void Sq(int side1, int side2, int side3)
        {
            bool v = IsTriangle(side1, side2, side3);
            try
            {
                if (v)
                {
                    float halfPerimetr = checked((float)(side1 + side2 + side3)) / 2;
                    float result = checked((float)Math.Sqrt(halfPerimetr * (halfPerimetr - side1) * (halfPerimetr - side2) * (halfPerimetr - side3)));
                    Console.WriteLine($"Площадь треугольника со сторонами {side1},{side2},{side3} равна {result:0.00}.");
                }
                else
                {
                    throw new Exception("Стороны не подходят для треугольника");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
        static void Sq(int side)
        {
            float halfperimetr = checked((float)side * 3 / 2);
            Console.WriteLine("halperimter: " + halfperimetr + "side" + side);
            float result = checked((float)Math.Sqrt(halfperimetr * Math.Pow(halfperimetr - side, 3)));
            Console.WriteLine($"Площадь равностороннего треугольника со стороной {side} равна {result:0.00}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation.Choice();
        }
    }
}
