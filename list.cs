using System;
using System.Collections.Generic;

class Gaurab
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string>();
        names.Add("Ram");
        names.Add("Hari");

        names.Add("Sam");
        Console.WriteLine(names.IndexOf("Ram"));
        Console.WriteLine(names.Count);
        names.RemoveAt(2);
        //names.Remove("Ram");
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }
        Console.ReadKey();
    }
}

