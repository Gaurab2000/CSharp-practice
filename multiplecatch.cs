using System;

namespace labreport
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            try
            {
                int a = 2;
                int b = 2;//if b=0 divide by zero exception will run first
                int c = a / b;//only one exception can occur at a time
                Console.WriteLine(c);
                arr[0] = 11;
                arr[1] = 12;
                arr[2] = 13;
                arr[3] = 14;
                foreach (int i in arr)
                {
                    Console.WriteLine(i);

                }
               
            }
            catch (IndexOutOfRangeException ex)

            {

                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException eg)
            {
                Console.WriteLine(eg.Message);

            }
            Console.ReadKey();
        }

    }
}
