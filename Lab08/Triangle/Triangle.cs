internal class Triangle
{
    public int side1 { get; private set; }
    public int side2 { get; private set; }
    public int side3 { get; private set; }
    public int Perimetr { get; private set; }
    public double Area { get; private set; }

    public Triangle(int a, int b, int c)
    {
        try
        {
            if (Operations.IsTriangle(a, b, c))
            {
                side1 = a; side2 = b; side3 = c;
                Perimetr = PerimetrCalc();
                Area = AreaCalc();
            }
            else
            {
                throw new InvalidOperationException("Треугольник не создан");
            }
        }
        catch (Exception e) 
        {
            Console.WriteLine(e.Message);
        }
    }

    public Triangle(int a)
    {
        side1 = side2 = side3 = a;
        Perimetr = PerimetrCalc();
        Area = AreaCalc();
    }

    public int PerimetrCalc() => side1 + side2 + side3;

    public double AreaCalc()
    {
        double halfperiment = (double)Perimetr / 2;
        double area = Math.Sqrt(halfperiment * (halfperiment - side1) * (halfperiment - side2) * (halfperiment - side3));
        return area;
    }
}