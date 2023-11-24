namespace Sqrt
{
    public class Program
    {
        static double Sqrt(double num)
        {
            double x = 1;
            double oldx;
            do
            {
                oldx = x;
                x = (x + num / x) / 2;
            }
            while (oldx != x);
            return x;
        }

        static void ShowSqt(double num)
        {
            double sqrt = Sqrt(num);
            Console.WriteLine($"���������� ������ �� {num:F} = {sqrt:F};\n" +
                              $"{sqrt:F} * {sqrt:F} = {sqrt * sqrt:F}");
        }

        static void Main(string[] args)
        {
            Console.Write("������� ����� ��� ���������� ����������� �����: ");
            double strSqrt = Double.Parse(Console.ReadLine());

            ShowSqt(strSqrt);
        }
    }
}
    


