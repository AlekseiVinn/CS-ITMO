namespace MatrixMultiply
{
    internal class MatrixMultiply
    {

        static void Input(int[,] matrix)
        {
            Console.WriteLine("Заполните матрицу формата 2х2");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Введите аргумент матрицы [{i},{j}]: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Сформирована матрица:");
            OutPut(matrix);
            Console.WriteLine();
        }

        static void OutPut(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Multiply(int[,] matrix1, int[,] matrix2) 
        {
            int[,] result = new int[2,2];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i,0] * matrix2[0,j] + matrix1[i,1] * matrix2[1,j];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] a = new int[2,2];
            int[,] b = new int[2,2];

            Input(a);
            Input(b);

            //int[,] a = { { 1, 2 }, { 3, 4 } };
            //int[,] b = { { 5, 6 }, { 7, 8 } };

            int[,] result = Multiply(a, b);

            OutPut(result);


        }
    }
}
