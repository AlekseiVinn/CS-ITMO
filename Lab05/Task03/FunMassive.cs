using System.Runtime.CompilerServices;

namespace Task03
{
    internal class FunMassive
    {
        static int[] CreateArray(int len)
        { 
            int[] newArray = new int[len];
            Random rnd = new Random();
            for (int i = 0; i < len; i++) 
            {
                newArray[i] = rnd.Next(-100,101);
                //newArray[i] = int.Parse(Console.ReadLine());
            }
            return newArray;
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + ", "  );
            }
            Console.WriteLine();
        }

        static int SumOfArray(int[] array)
        { 
            int sum = 0;
            foreach (int i in array)
            { 
                sum += i;
            }
            return sum;
        }

        static float Average(int[] array)
        { 
            float average = (float)SumOfArray(array) / array.Length;
            return average;
        }

        static (int Pos, int Neg) SumSeparate(int[] array)
        {
            int resultPos = 0;
            int resultNeg = 0;
            foreach (int i in array)
            {
                _ = (i >= 0) ? resultPos += i : resultNeg +=i;
            }
            return (resultPos, resultNeg);
        }

        static (int Even, int Uneven) SumPositions(int[] array)
        {
            int resultEven = 0;
            int resultUneven = 0;
            for (int i = 1; i <= array.Length; i++)
            {
                _ = (i % 2 == 0) ? resultEven += array[i-1] : resultUneven += array[i - 1];
            }
            return (resultEven, resultUneven);
        }

        static int IndexOfMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = (max > array[i]) ? max : array[i];

            }
            //Console.WriteLine("---Максимальное значение массива = " + max + "---");
            return Array.IndexOf(array, max);
        }

        static int IndexOfMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = (min < array[i]) ? min : array[i];

            }
            //Console.WriteLine("---Минимальное значение массива = " + min + "---");
            return Array.IndexOf(array, min);
        }

        static int MultBeetwMinMax(int[] array)
        { 
            int maxIndex = IndexOfMax(array);
            int minIndex = IndexOfMin(array);
            int res = 1;
            if (maxIndex - minIndex == 1 || minIndex - maxIndex ==1) 
            {
                return 0; 
            }
            int[] arraySlice = (maxIndex > minIndex) ? array[(minIndex+1)..maxIndex] : array[(maxIndex+1)..minIndex];
            
            foreach (int i in arraySlice)
            { 
                res *= i;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int len = int.Parse(Console.ReadLine());
            int[] userArray = CreateArray(len);
            Console.WriteLine("Создан массив: ");
            PrintArray(userArray);

            Console.WriteLine("Cумма элементов массива = " + SumOfArray(userArray));
            Console.WriteLine($"Среднее значение элементов массива = {Average(userArray):0.00}");


            Console.WriteLine("Cумма положительных элементов массива = " + SumSeparate(userArray).Pos);
            Console.WriteLine("Cумма отрицательных элементов массива = " + SumSeparate(userArray).Neg);

            Console.WriteLine("Cумма четных элементов массива = " + SumPositions(userArray).Even);
            Console.WriteLine("Cумма сумма нечетных элементов массива = " + SumPositions(userArray).Uneven);

            Console.WriteLine("Индекс максимального значаение массива = " + IndexOfMax(userArray));
            Console.WriteLine("Индекс минимального значаение массива = " + IndexOfMin(userArray));
            Console.WriteLine("Произведение элементов массива, расположенных между максимальным и минимальным элементами = " + MultBeetwMinMax(userArray));

            //int[] test1 = { 1, 4, -1, 0 };
            //int[] test2 = { 1, -1, 4, 0 };
            //int[] test3 = { 4, 1, 2, -1 };
            //int[] test4 = { -1, 1, 2, 4 }; 
            //Console.WriteLine("Тест 1= " + MultBeetwMinMax(test1));
            //Console.WriteLine("Тест 2= " + MultBeetwMinMax(test2));
            //Console.WriteLine("Тест 3= " + MultBeetwMinMax(test3));
            //Console.WriteLine("Тест 4= " + MultBeetwMinMax(test4));

        }
    }
}
