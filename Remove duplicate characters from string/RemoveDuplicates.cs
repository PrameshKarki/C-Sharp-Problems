// C# program to remove duplicate characters from given string
using System;
namespace RemoveDuplicatesProgram {
    class MainClass {
        static void Main (string[] args) {
            string givenString, uniqueString = "";
            int length;
            Console.Write ("Enter any string to remove duplicate characters:");
            givenString = Console.ReadLine ();
            uniqueString += givenString[0];
            length = givenString.Length;
            for (int index = 1; index <= length - 1; index++) {
                if (!uniqueString.Contains (givenString[index].ToString ()))
                    uniqueString += givenString[index];
            }
            Console.WriteLine ("Given string:{0}", givenString);
            Console.WriteLine ("Unique string:{0}", uniqueString);
            Console.Read ();
        }
    }
}
//Pramesh Karki