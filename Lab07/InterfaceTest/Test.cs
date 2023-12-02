namespace Statrter
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            int i = 0;
            char c = 'a';
            ulong l = 185461321656874656;
            string s = "ABCDEFG";

            Console.WriteLine(
                $"int is formattable: {Utils.IsItFormattable(i)}\n" +
                $"char is formattable: {Utils.IsItFormattable(c)}\n" +
                $"ulong is formattable: {Utils.IsItFormattable(l)}\n" +
                $"string is formattable: {Utils.IsItFormattable(s)}"
                );

            
        }
    }
}
