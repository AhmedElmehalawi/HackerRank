using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
         int intValue;
         double doubleValue;
         string stringValue;
         
        // Read and save an integer, double, and String to your variables.
        intValue =  int.Parse(Console.ReadLine());
        doubleValue =  double.Parse(Console.ReadLine());
        stringValue =  Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+intValue);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", (double)(d+doubleValue)));
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine($"{s}{stringValue}");
    }
}
