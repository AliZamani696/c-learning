

using System;
using System.IO;



class SimpleTextEditor
{
    static void Main()
    {
        Console.WriteLine("=== Simple Text Editor ===");
        Console.WriteLine("Type your text below (press ESC when done):\n");

        string text = ReadMultiLineText();

        Console.WriteLine("\n\nYour text:");
        Console.WriteLine("----------");
        Console.WriteLine(text);
        Console.WriteLine("----------");

        Console.Write("\nSave to file? (y/n): ");
        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            Console.Write("\n enter your filename");
            string filename = Console.ReadLine();
            File.WriteAllText(filename,text);
            Console.WriteLine("saved!");
        }
    }
    static string ReadMultiLineText()
    {
        string text = "";
        string line = "";
        bool Writing = true;

        while ( Writing )
        {
            ConsoleKeyInfo key =Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)Writing = false;
            else if(key.Key == ConsoleKey.Enter)
            {
                text += line + Environment.NewLine;
                line = "";
                Console.WriteLine();
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                if (line.Length > 0)
                {
                    line = line.Substring(0,line.Length -1);
                    Console.Write("\b\b");
                }
            }
            else
            {
                line += key.KeyChar;
                Console.Write(key.KeyChar);
            }

        }
        text += line;
        return text;
    }
}
