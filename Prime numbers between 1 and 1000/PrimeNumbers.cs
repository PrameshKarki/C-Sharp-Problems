// C# program to print prime numbers from 1 to 1000
using System;
namespace DisplayPrimeNumberProgram {
    class MainClass {
        static void Main (string[] args) {
            PrimeNumbers.Display ();
            Console.Read ();

        }
    }
    class PrimeNumbers {
        static public void Display () {
            int min = 1, max = 1000, i, j, count;
            for (i = min; i < max; i++) {
                count = 0;
                for (j = 1; j <= (i / 2); j++) {
                    if (i % j == 0) {
                        count++;
                    }

                }
                if (count == 1) {
                    Console.Write (i + ",");

                }
            }
        }

    }
}
//Pramesh Karki