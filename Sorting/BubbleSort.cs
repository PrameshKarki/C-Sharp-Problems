// C# implementation of Bubble sort
using System;
namespace SortingProgram {
    class MainClass {
        static void Main (string[] args) {
            int[] myArray = new int[100];
            int size;
            MainClass obj = new MainClass ();
            Console.Write ("How many element do you want to store in an array? ");
            size = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Enter {0} elements:", size);
            for (int i = 0; i < size; i++)
                myArray[i] = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Before sorting:");
            obj.Display (myArray, size);
            obj.BubbleSort (myArray, size);
            Console.WriteLine ("\nAfter sorting:");
            obj.Display (myArray, size);
            Console.Read ();

        }
        public void Display (int[] givenArray, int length) {
            for (int index = 0; index < length; index++) {
                Console.Write (givenArray[index] + " ");

            }
        }
        public void BubbleSort (int[] givenArray, int size) {
            int i, j, temp;
            for (i = 0; i < size - 1; i++) {
                //Last i elements are already in place
                for (j = 0; j < size - 1 - i; j++) {
                    if (givenArray[j] > givenArray[j + 1]) {
                        temp = givenArray[j];
                        givenArray[j] = givenArray[j + 1];
                        givenArray[j + 1] = temp;

                    }
                }
            }
        }

    }

}

//Pramesh Karki