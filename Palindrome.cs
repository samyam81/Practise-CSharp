using System;
using System.Linq;

namespace Samyam{
    class palindrome{
        static void Main(){
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();
            string reversedStr = new string(str.Reverse().ToArray());
            
            if(str==reversedStr){
                Console.WriteLine("Palindrome");
            } else
                Console.WriteLine("Not Palindrome");
        }
    }
}
