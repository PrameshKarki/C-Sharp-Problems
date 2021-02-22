// C# program to calculate sum of all elements in an array
using System;
namespace SumProgram {
    class MainClass {
        static void Main (string[] args) {
            SumOfArray obj = new SumOfArray ();
            obj.getSize ();
            obj.getElements ();
            obj.calculateSum ();
            Console.Read ();
        }
    }
    class SumOfArray {
        int size;
        int[] myArray = new int[100];
        public void getSize () {
            Console.Write ("How many element do you want to insert in an array? ");
            size = Convert.ToInt32 (Console.ReadLine ());
        }
        public void getElements () {
            Console.WriteLine ("Enter {0} elements to find sum:",size);
            for (int index = 0; index < size; index++)
                myArray[index] = Convert.ToInt32 (Console.ReadLine ());
        }
        public void calculateSum () {
            int sum = 0;
            for (int index = 0; index < size; index++)
                sum += myArray[index];
            Console.WriteLine ("The sum is:{0}", sum);
        }
    }
}
//Pramesh Karki
