namespace EquationToTuple
{
    internal class Program
    {
        /**static int Solving(ref float x1, ref float x2, int a, int b, int c)
        {
            float discriminant = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант = " + discriminant);
            if (discriminant < 0) return -1;
            else if (discriminant == 0)
            {
                x1 = x2 = -b / 2 * a;
                return 0;
            }
            else
            { 
                x1 = (-b + checked((float)Math.Sqrt(discriminant))) / 2 * a;
                x2 = (-b - checked((float)Math.Sqrt(discriminant))) / 2 * a;
                return 1;
            }**/

        static (int Flag, float? X1, float? X2) Solving(int a, int b, int c)
        {
            float discriminant = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант = " + discriminant);
            if (discriminant < 0) return (-1, null, null);
            else if (discriminant == 0)
            {
                float res = (float)(b / 2 * a);
                return (0, res, res);
            }
            else
            {
                float x1 = (-b + checked((float)Math.Sqrt(discriminant))) / 2 * a;
                float x2 = (-b - checked((float)Math.Sqrt(discriminant))) / 2 * a;
                return (1, x1, x2);
            }
        }

        static void Results(int a, int b, int c)
        {
            var result = Solving(a, b, c);
            switch (result.Flag) 
            {
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет\n");
                    break;
                case 0:
                    Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c} один x1=x2={result.X1:0.00}\n");
                    break;
                case 1:
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны x1={result.X1:0.00}, x2={result.X2:0.00}\n");
                    break;

            }
        }

        static (int A,int B, int C) ThrowNewVars()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 11);
            int b = rnd.Next(-10, 11);
            int c = rnd.Next(-10, 11);
            return (a,b,c);
        }

        static void Main(string[] args)
        {
            (int a, int b, int c )= ThrowNewVars();

            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(a,b,c);

            (a,b,c) = ThrowNewVars();
            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(a, b, c);

            (a, b, c) = ThrowNewVars();
            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(a, b, c);

            (a, b, c) = ThrowNewVars();
            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(a, b, c);

            (a, b, c) = ThrowNewVars();
            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(a, b, c);
        }
    }
}
