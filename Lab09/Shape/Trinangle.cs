class Trinangle : Shape, IMove
{
    private int len1, len2;

    public Trinangle(int len0, int len1, int len2) : base(len0)
    {
        this.len1 = len1;
        this.len2 = len2;
        Area();
        FigureLenght();
    }

    public override void Show()
    {
        Console.WriteLine(
            $"Треугольник {GetType().Name} со сторонами: {len0}, {len1}, {len2}\n" +
            $"Периметр треукольника: {Perimetr:F}\n" +
            $"Площадь круга: {GetArea:F}\n");
    }

    public override void Area()
    {
        double halfperimetr = (double)(len0 + len1 + len2) / 2;
        area = Math.Sqrt(halfperimetr * (halfperimetr - len0) * (halfperimetr - len1) * (halfperimetr - len2));
    }

    public double GetArea { get { return area; } }

    public override void FigureLenght()
    {
        length = len0 + len1 + len2;
    }

    public double Perimetr { get { return length; } }

    public void Move()
    {
        Console.WriteLine($"Треугольник {GetType().Name} провернулся вокруг своего центра");
    }
}
