using System;
using System.Text;

class Lab9T1
{
    public void Run()
    {
        Console.WriteLine("Введи текст з # (Backspace):");
        string input = Console.ReadLine();
        string result = ProcessBackspace(input);
        Console.WriteLine("Оброблений текст:");
        Console.WriteLine(result);
    }

    private string ProcessBackspace(string text)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in text)
        {
            if (c == '#')
            {
                if (sb.Length > 0)
                    sb.Length--; 
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
