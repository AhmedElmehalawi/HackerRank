using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfNames = int.Parse(Console.ReadLine());
        
        Dictionary<string, string> phoneBook  = new Dictionary<string, string>();
        
        for(int i=0 ; i<numberOfNames; i++){
            string[] friendData = Console.ReadLine().Split(' ');
            phoneBook.Add(friendData[0], friendData[1]);
        }
        
        string nameToCheck;
        while((nameToCheck=Console.ReadLine()) != null){
            
            if(phoneBook.ContainsKey(nameToCheck) )
                Console.WriteLine($"{nameToCheck}={phoneBook[nameToCheck]}");
            else
                Console.WriteLine("Not found");
        }
        
    }
}
