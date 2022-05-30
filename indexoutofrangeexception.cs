using System;

namespace labreport { 
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            try
            {
                arr[0] = 11;
                arr[1] = 12;
                arr[2] = 13;
                arr[3] = 14;
                foreach (int i in arr)
                {
                    Console.WriteLine(i);

                }
            }
            catch(IndexOutOfRangeException ex)

            {
                Console.WriteLine("Array's range is exceede...");
                Console.WriteLine(ex.Message);
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadKey();
        }

    }
}