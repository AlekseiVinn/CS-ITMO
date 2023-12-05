using System;

public class Program
{
    static void Main()
    {
        Distance dist1 = new Distance();
        Distance dist2 = new Distance(1,1);
        Distance dist3 = new Distance(1,11);
        Distance dist4 = new Distance(2,0);
        Distance dist5 = dist4 - dist3 + dist2;
        Distance dist6 = new Distance(1,1);

        Console.WriteLine(dist5);
        Console.WriteLine();
        Console.WriteLine(dist4 > dist5);
        Console.WriteLine(dist4 < dist5);
        Console.WriteLine(dist6 != dist5);
        Console.WriteLine(dist6 != dist2);

        Console.WriteLine(dist1 + " - " + dist2  +" = " + (dist1-dist2));
        Console.WriteLine(dist1 + " + " + dist2 + " = " + (dist1 + dist2));
        Console.WriteLine(dist1 + " - " + dist3 + " = " + (dist1 - dist3));
        Console.WriteLine(dist2 + " - " + dist3 + " = " + (dist2 - dist3));
        Console.WriteLine(dist3 + " - " + dist4 + " = " + (dist3 - dist4));
        Console.WriteLine(dist4 + " - " + dist3 + " = " + (dist4 - dist3));
        Console.WriteLine(dist2 + " + " + dist3 + " = " + (dist2 + dist3));
    }
}

