using System;
using System.IO;

/// <summary>
///    Class to create an upper case copy of a file
/// </summary>
public class CopyFileUpper
{
    public static void Main()
	{
        Console.WriteLine("Enter path to file to read from:");
        string sFrom = Console.ReadLine();
        Console.WriteLine("Enter path to file to write in:");
        string sTo = Console.ReadLine();

        try
        {
            StreamReader srFrom = new StreamReader(sFrom);
            StreamWriter swTo = new StreamWriter(sTo);
            //StreamReader srFrom = new StreamReader("E:\\C#\\C# ITMO\\FoTR.txt");
            //StreamWriter swTo = new StreamWriter("E:\\C#\\C# ITMO\\FoTR2.cs");
            while (srFrom.Peek() != -1)
            {
                string temp = srFrom.ReadLine();
                swTo.WriteLine(temp.ToUpper());
            }
            swTo.Close();
            srFrom.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not Found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
            
    }
}
