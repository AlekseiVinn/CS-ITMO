using System;


namespace modu_2_
{
    /// <summary> 
    /// Задача 1.
    /// Требуется реализовать печать заголовка таблицы вывода значений функции
    /// С помощью цикла с постусловием реализуйте вывод значений функции sin(x) на интервале от x1 до x2 с шагом 0,01
    /// Используйте четыре переменных вещественного типа:
    /// x – аргумент функции, x1, x2 – границы интервала, y – выходной параметр функции, 
    /// для границ интервала реализуйте ввод значений  с клавиатуры.
    /// Задача 2.
    /// Требуется определить наибольший общий делитель двух целых чисел по алгоритму Евклида
    /// a и b -входные данные
    /// nod - искомое значение
    /// </summary>
    
    class LoopProgram
    {

        static void SinX(double x1, double x2)
        {
            Console.WriteLine($"sin(x), x in ({x1:0.00};{x2:0.00};+0.01)");
            Console.WriteLine("_____________________________");
            do
            {
                Console.WriteLine($"| x = {x1:0.00}  | sin(x) = {Math.Sin(x1):0.00}  |");
                x1 +=0.01;
            }
            while ( x1 <= x2 );
            Console.WriteLine("_____________________________\n");
        }

        static int Nod(int num1, int num2)
        {
            while (num1 != num2)
            {
                //if (a > b)
                //    a -= b;
                //else
                //    b -= a;
                _ = num1 > num2 ? num1 -= num2 : num2 -= num1;
            }
            return num1;
        }
        
        static void Main()
        {
            // 1
            Console.WriteLine("Нахождение sin(x) в пределах (х1,х2)");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());

            SinX(x1, x2);


            // 2
            Console.Write("Введите первое число для нахождения НОД:  ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число для нахождения НОД:  ");
            int b = int.Parse(Console.ReadLine());
            
            int nod = Nod(a, b);
            Console.WriteLine($"НОД({a},{b}) = {nod}");
        }

    }
}
