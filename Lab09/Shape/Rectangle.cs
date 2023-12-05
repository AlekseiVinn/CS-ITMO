class Rectangle : Shape, IMove
{

    public Rectangle(int len0) : base(len0)
    {
        Area();
        FigureLenght();
    }

    public Rectangle() { }

    public void Move()
    {
        Console.WriteLine($"Квадрат {GetType().Name} провернулся вокруг своего центра");
    }

    public override void Show()
    {
        Console.WriteLine(
            $"Квадрат {GetType().Name} со сторонами {len0}\n" +
            $"Периметр квадрата: {Perimetr}\n" +
            $"Площадь квадрата: {GetArea:F}\n");
    }

    public override void Area()
    {
        area = len0 * len0;
    }

    public double GetArea { get { return area; } }

    public override void FigureLenght()
    {
        length = len0 * 4;
    }

    public double Perimetr { get { return length; } }


}
