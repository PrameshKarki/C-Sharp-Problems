// C# program to reverse the given number
using System;
namespace ReverseNumberProgram {
    class MainClass {
        static void Main (string[] args) {
            int givenNumber, reverseNumber = 0;
            Console.Write ("Enter any number to reverse it:");
            givenNumber = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Given Number:{0}", givenNumber);
            while (givenNumber > 0) {
                int remainder = givenNumber % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                givenNumber = givenNumber / 10;
            }
            Console.WriteLine ("Reverse Number:{0}", reverseNumber);
            Console.Read ();
        }

    }
}

//Pramesh Karki