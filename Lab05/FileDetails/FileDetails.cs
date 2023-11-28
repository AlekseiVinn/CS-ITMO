using System;            //Console
using System.IO;         //FileStream, FileReader

namespace FileDetails
{
    internal class FileDetails
    {
        //chars - CMD-argument в настройках запуска "E:\C#\C# ITMO\Lab05\FileDetails\FileDetails.cs"
        static void Summarize(char[] chars)
        {
            int vowels = 0;
            int consonants = 0;
            int newLines = 0;
            
            foreach (char ch in chars) 
            {
                if (Char.IsLetter(ch))
                {
                    _ = "AEIOUaeiou".IndexOf(ch) != -1 ? vowels++ : consonants++;
                }
                else if (ch == '\n')
                {
                    newLines++;
                }
            }
            Console.WriteLine(
                $"Total No of characters: {chars.Length}.\n" +
                $"Total No of vowels: {vowels}.\n" +
                $"Total No of consonants: {consonants}.\n" +
                $"Total No of lines: {newLines}.");
        }
        
        static void Main(string[] args)
        {
            string fileName = args[0];

            /**Console.WriteLine(args.Length);
            foreach (string str in args) 
            {
                Console.WriteLine(str);
            }**/

            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream); 

            int size = checked((int)stream.Length);
            char[] contents = new char[size];

            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }

            /**foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            Console.WriteLine();**/

            Summarize(contents);

            reader.Close();
            // А нужно писать "stream.Close();" ?
            // Visual Studio предлагает.
        }
    }
}