using System;
namespace labreport { 
public abstract class Nepal
{
    public abstract void State();
}
public class Bagmati: Nepal
{
    public override void State()
    {
        Console.WriteLine("class Bagmati");

    }

    
}
public class Lumbini : Nepal
{
    public override void State()
    {
        Console.WriteLine("class Lumbini");
    }
}

public class Earth
{
    static void Main(string[] args)
    {
        Nepal n;
        n = new Bagmati();
        n.State();  
        n= new Lumbini();
        n.State();
        Console.ReadKey();  
        
    

    }
    }
}
