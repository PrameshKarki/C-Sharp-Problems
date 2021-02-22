// C# program to demonstrate List(collection)
using System;
using System.Collections.Generic;
namespace ListProgram {
    public class MainClass {
        static void Main (string[] args) {
            //Declaring list of string type
            List<string> myList = new List<string> ();
            //Adding elements in the list
            myList.Add ("C");
            myList.Add ("C++");
            myList.Add ("Javascript");
            myList.Add ("C#");
            myList.Add ("C#");
            //Checking wheather list containes "Javascript" or not
            Console.WriteLine (myList.Contains ("Javascript"));
            //Acessing elements with the help of index
            Console.WriteLine (myList[2]);
            //Inserting element at the end
            myList.Insert (myList.Count, "Last element");
            //Sorting list
            myList.Sort ();
            //Displaying count
            Console.WriteLine ("Count:{0}", myList.Count);
            //Displaying Capacity
            Console.WriteLine ("Capacity:{0}", myList.Capacity);
            //Removing "last element"
            myList.Remove ("Last element");
            // Removing all the elements of the list
            //    myList.Clear();
            //Traversing elements of the list
            Console.WriteLine ("Elements in the list:");
            foreach (string element in myList) {
                Console.WriteLine (element);
            }
            Console.Read ();
        }
    }
}

//Pramesh Karki