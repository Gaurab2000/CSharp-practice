using System;
namespace ConsoleApp1
{
    class Gau
    {
        public string name;
        public string subject;

        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("MYSELF:" + name);
            Console.WriteLine("my favoutrite subject is :" + subject);

        }

    }
    class Rab : Gau
    {
        public void outputtext()
        {
            Console.WriteLine("C sharp");

        }
    }

    class Final
    {
        
        static void Main(string[] args
            )
        {
            Rab r = new Rab();
            r.readers("Gaurab", "c sharp");
            Console.ReadLine();
        }
    }

}