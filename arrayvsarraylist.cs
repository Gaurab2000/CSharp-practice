using System;
  
class Gaurab{
  
    // Main Method
    public static void Main(string[] args)
    {
  
        // creating array
        int[] arr = new int[4];
  
        // initializing array
        arr[0] = 47;
        arr[1] = 77;
        arr[2] = 87;
        arr[3] = 97;
  
        // traversing array
        for (int i = 0; i < arr.Length; i++) {
  
            Console.WriteLine(arr[i]);
        }
    }
}


// C# program to illustrate the ArrayList
using System;
using System.Collections;
  
class Gaurab {
  
    // Main Method
    public static void Main(string[] args)
    {
  
        // Create a list of strings
        ArrayList al = new ArrayList();
        al.Add("Ajay");
        al.Add("Ankit");
        al.Add(10);
        al.Add(10.10);
  
        // Iterate list element using foreach loop
        foreach(var names in al)
        {
            Console.WriteLine(names);
        }
    }
}
