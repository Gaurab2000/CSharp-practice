using System;
namespace geeksforgeeks {
  
class GFG {
  
    // Main Method
    public static void Main()
    {
  
        // declares a 1D Array of string.
        string[] weekDays;
  
        // allocating memory for days.
        weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",
                                      "Thu", "Fri", "Sat" };
  
        // using Rank Property
        Console.WriteLine("Dimension of weekDays array: " 
                                       + weekDays.Rank);
    }
}
}
