// C# program to reverse the given string
using System;
namespace ReverseStringProgram {
    class MainClass {
        static void Main (string[] args) {
            string givenString, reversedString = "";
            Console.WriteLine ("Enter any string to reverse it:");
            givenString = Console.ReadLine ();
            int length = givenString.Length - 1;
            while (length >= 0) {
                reversedString += givenString[length];
                length--;
            }

            Console.WriteLine ("Given string:{0}", givenString);
            Console.WriteLine ("Reversed string:{0}", reversedString);
            Console.Read ();

        }
    }

}

//Pramesh Karki