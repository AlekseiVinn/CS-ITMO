namespace Task05
{
    internal class Program
    {
        static int Solving(ref float x1, ref float x2, ref int a, ref int b, ref int c)
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
            }

        }

        static void Results(ref float x1, ref float x2, ref int a, ref int b, ref int c)
        {
            int flag = Solving(ref x1, ref x2, ref a, ref b, ref c);
            switch (flag) 
            {
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} нет\n");
                    break;
                case 0:
                    Console.WriteLine($"Корень уравнения с коэффициентами a = {a}, b = {b}, c = {c} один x1=x2={x1:0.00}\n");
                    break;
                case 1:
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны x1={x1:0.00}, x2={x2:0.00}\n");
                    break;

            }
        }

        static void ThrowNewVars(ref float x1, ref float x2, ref int a, ref int b, ref int c)
        {
            Random rnd = new Random();
            a = rnd.Next(1, 11);
            b = rnd.Next(-10, 11);
            c = rnd.Next(-10, 11);
            x1 = 0;
            x2 = 0;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,11);
            int b = rnd.Next(-10,10);
            int c = rnd.Next(-10,10);
            float x1 = 0;
            float x2 = 0;

            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(ref x1, ref x2, ref a, ref b, ref c);

            ThrowNewVars(ref x1, ref x2, ref a, ref b, ref c);
            Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            Results(ref x1, ref x2, ref a, ref b, ref c);

            //ThrowNewVars(ref x1, ref x2, ref a, ref b, ref c);
            //Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            //Results(ref x1, ref x2, ref a, ref b, ref c);

            //ThrowNewVars(ref x1, ref x2, ref a, ref b, ref c);
            //Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            //Results(ref x1, ref x2, ref a, ref b, ref c);

            //ThrowNewVars(ref x1, ref x2, ref a, ref b, ref c);
            //Console.WriteLine($"Квадратное уравнение вида {a}x^2 + {b}x + {c} = 0");
            //Results(ref x1, ref x2, ref a, ref b, ref c);


        }
    }
}
