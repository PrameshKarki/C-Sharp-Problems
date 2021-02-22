// C# program to display largest number among given three numbers
using System;
namespace LargestNumberProgram {
    class MainClass {
        static void Main (string[] args) {
            int[] numbers = new int[3];
            int largestNumber, temp;
            Console.Write ("Enter three numbers to find largest among them:");
            for (int index = 0; index < 3; index++) {
                numbers[index] = Convert.ToInt32 (Console.ReadLine ());
            }
            temp = numbers[0] > numbers[1] ? numbers[0] : numbers[1];
            largestNumber = temp > numbers[2] ? temp : numbers[2];
            Console.WriteLine ("Largest Number is:{0}", largestNumber);
            Console.Read ();

        }
    }
}

//Pramesh Karki