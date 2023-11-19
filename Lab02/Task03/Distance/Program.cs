using System;

namespace Distance
{
    public struct Distance
    {
        public int feet;
        public int inches;

        public Distance(int inches) 
        {
            this.feet = inches / 12;
            this.inches = inches % 12;
        }
        public Distance(int feet, int inches)
        {
            this.feet = feet;
            this.inches = inches;
        }

        public static Distance operator +(Distance a, Distance b) 
        {
            int newFeet = (a.feet + b.feet) + (a.inches + b.inches) / 12;
            int newInches = (a.inches + b.inches) % 12;
            return new Distance(newFeet, newInches);
        }

        public void WriteDistance()
        {
            Console.WriteLine($"{this.feet}'-{this.inches}\"");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое значение: ");
            string info = Console.ReadLine();
            
            Distance distance1 = CreateDistance(info);
            distance1.WriteDistance();

            Console.Write("Введите второе значение: ");
            info = Console.ReadLine();
            
            Distance distance2 = CreateDistance(info);
            distance2.WriteDistance();

            Distance distance3 = distance1 + distance2;
            distance3.WriteDistance();

            Console.ReadLine();
        }

        static Distance CreateDistance(string info) 
        {
            if (int.TryParse(info, out int inches))
            {
                return new Distance(inches);
            }
            else
            {
                throw new InvalidOperationException("No element satisfies the given condition.");
            }
        }
    }
}
