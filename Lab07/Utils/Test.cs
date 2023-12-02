namespace Statrter
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            /**Random rnd = new Random();
            int num1 = rnd.Next();
            int num2 = rnd.Next();

            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(num1, num2);
            Console.WriteLine($"\nБольшее число из двух: {greater}\n");

            Utils.Swap(ref num1, ref num2);
            Console.WriteLine($"Перове число = {num1};\nВторое число = {num2}");

            int f;
            bool ok;

            Console.Write("Число для факториала: ");
            int x = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(x, out f);
            if (ok)
            {
                Console.WriteLine($"Факториал {x}! = {f}");
            }
            else
            {
                Console.WriteLine("Не могу вычислить факториал");
            }**/

            Console.Write("Enter test string: ");
            string test = Console.ReadLine();
            Utils.Reverse(ref test);
            Console.WriteLine(test);

        }
    }
}
