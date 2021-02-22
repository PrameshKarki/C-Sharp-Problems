// C# program to print the following pattern
// Pattern:
// 1
// 1 2
// 1 2 3
// 1 2 3 4
using System;
namespace PatternPrograms {
    class MainClass {
        static void Main (string[] args) {
            DisplayPattern.Display();
            Console.Read();

        }
    }
    class DisplayPattern {
        static public void Display () {
            int i,j;
            for (i = 0; i < 4; i++) {
                for (j = 0;j<=i;j++){
                    Console.Write((j+1)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Pramesh Karki