internal class Operations
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return _ = (a >= b + c || b >= a + c || c >= a + b) ? false : true;
    }

    static (int a, int b, int c) SetLengths()
    {
        int[] sides = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Введите длину {i + 1}й стороны треугольника: ");
            sides[i] = int.Parse(Console.ReadLine());
            if (sides[i] <= 0)
            {
                ArgumentOutOfRangeException e = new ArgumentOutOfRangeException("Сторона треугольника - натуральное число");
                throw e;
            }
        }
        return (sides[0], sides[1], sides[2]);
    }

    public static Triangle? NewTriange()
    {
        try
        {
            (int side1, int side2, int side3) = SetLengths();
            if (IsTriangle(side1, side2, side3))
            {
                return new Triangle(side1, side2, side3);
            }
            else
            {
                ArgumentOutOfRangeException e = new ArgumentOutOfRangeException("Введенные стороны не подходят для создания треугольника. 1 из сторон >= сумме оставшихся");
                throw e;
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
}

