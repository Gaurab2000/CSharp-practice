using System;
namespace csharpractice
{
    class Gaurab
    {
        private string month;
        private int year;

        public Gaurab(Gaurab s)
        {
            month = s.month;
            year = s.year;
        }
        public Gaurab(string month, int year)
        {
            this.month = month;
            this.year = year;
        }
        public string Details
        {
            get
            {
                return " Month:" + month.ToString() +
                       "\n Year:" + year.ToString();
            }
        }
       static void Main()
        {
            Gaurab g1 = new Gaurab("august", 2000);
            Gaurab g2 = new Gaurab(g1);
            Console.WriteLine(g2.Details);
            Console.ReadLine();
        }

    }

}
