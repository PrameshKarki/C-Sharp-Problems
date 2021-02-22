// C# program to find largest and smallest number from an array
using System;
namespace ArrayProgram {
    class LargestAndSmallestNumber {
        static void Main (string[] args) {
            MyArrayClass obj = new MyArrayClass ();
            obj.GetNumberOfElements ();
            int largestNumber = obj.GetLargest ();
            int smallestNumber = obj.GetSmallest ();
            Console.WriteLine ("The largest number of an array is {0}", largestNumber);
            Console.WriteLine ("The smallest number of an array is {0}", smallestNumber);
            Console.Read ();
        }

    }
    class MyArrayClass {
        int size;
        int[] myArray = new int[100];
        public void GetNumberOfElements () {
            Console.WriteLine ("How many element do you want to store in an array:");
            Console.WriteLine ("Hint:Maximum 100 elements can be stored only!");
            size = Convert.ToInt32 (Console.ReadLine ());
            ReadValues ();

        }
        private void ReadValues () {
            Console.WriteLine ("Enter {0} elements:", size);
            for (int i = 0; i < size; i++) {
                Console.Write ("myArray[{0}]: ", i);
                myArray[i] = Convert.ToInt32 (Console.ReadLine ());
            }
        }
        public int GetLargest () {
            int largest = myArray[0];
            for (int i = 0; i < size; i++) {
                if (largest < myArray[i]) {
                    largest = myArray[i];
                }
            }
            return largest;
        }
        public int GetSmallest () {
            int smallest = myArray[0];
            for (int i = 0; i < size; i++) {
                if (smallest > myArray[i]) {
                    smallest = myArray[i];
                }
            }
            return smallest;
        }

    }
}
//Pramesh Karki