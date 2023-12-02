internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Создание треугольника");
        //Triangle ABC = Operations.NewTriange();
        //Console.WriteLine("Треугольник создан");

        Random rnd = new Random();

        Triangle ABC = new Triangle(rnd.Next(1,20), rnd.Next(1, 20), rnd.Next(1, 20));

        Console.WriteLine($"Стороны треугольника: {ABC.side1} ; {ABC.side2} ; {ABC.side3}.\n"+
                              $"Периметр треугольника АВС = {ABC.Perimetr}.\n"+
                              $"Площадь треугольника АВС = {ABC.Area:F}.\n");

        Triangle DEF = new Triangle(rnd.Next(0, 30));

        Console.WriteLine($"Стороны треугольника: {DEF.side1} ; {DEF.side2} ; {DEF.side3}.\n" +
                          $"Периметр треугольника АВС = {DEF.Perimetr}.\n" +
                          $"Площадь треугольника АВС = {DEF.Area:F}.\n");

    }
}
