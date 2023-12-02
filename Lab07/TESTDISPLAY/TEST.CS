namespace Utils
{
    using System;

    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        public static void Main() 
        {
            Random rnd = new Random();

            Coordinate c = new Coordinate(rnd.NextDouble(), rnd.NextDouble());
            Utils.Dispaly(c);

            Utils.Dispaly(1);
            Utils.Dispaly("string");
            Utils.Dispaly('V');
            long l = 1023013201455156365;
            Utils.Dispaly(l);
        }
    }
}
