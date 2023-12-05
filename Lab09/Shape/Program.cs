class Program
{
    static void Main()
    {
        Random rnd = new Random();

        Rectangle rectangleTest = new Rectangle(rnd.Next(1,20));
        rectangleTest.Show();

        Circle circleTest = new Circle(rnd.Next(1, 20));
        circleTest.Show();


        int[] lines = { rnd.Next(1,20), rnd.Next(1, 20), rnd.Next(1, 20) };
        if (TriangleInput(lines))
        { 
            Trinangle triangleTest = new Trinangle(lines[0], lines[1], lines[2]);
            triangleTest.Show();
        }
        else
        {
            Console.WriteLine("Не получилось создать треугольник");
        }

    }

    static bool TriangleInput(int[] lines)
    {
        bool flag = true;
        double halfP = (double)(lines[0] + lines[1] + lines[2]) / 2;
        foreach (int i in lines) 
        {
            if (i >= halfP)
            { flag = false; }
        }
        return flag;
    }

}