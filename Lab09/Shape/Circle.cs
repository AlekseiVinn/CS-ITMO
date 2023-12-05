class Circle : Shape
{
    public Circle(int len) : base(len)
    {
        Area();
        FigureLenght();
    }

    public override void Show()
    {
        Console.WriteLine(
            $"Кргу {GetType().Name} с радиусом {len0}\n" +
            $"Длина окружности: {Perimetr:F}\n" +
            $"Площадь треугольника: {GetArea:F}\n");
    }

    public override void Area()
    {
        area = Math.PI * Math.Pow(len0,2);
    }

    public double GetArea { get { return area; } }

    public override void FigureLenght()
    {
        length = Math.PI * len0 * 2;
    }

    public double Perimetr { get { return length; } }

}
