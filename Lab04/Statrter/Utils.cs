namespace Statrter
{
    class Utils
    {
        public static int Greater(int num1, int num2) => num1 > num2 ? num1 : num2;

        public static void Swap(ref int num1, ref int num2)
        { 
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static bool Factorial(int num, out int answer)
        {
            int k, f;
            bool ok = num > 0? true : false;

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= num; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            { 
                f = 0;
                ok = false;
            }
            answer = f;

            return ok;
        }

    }
}
