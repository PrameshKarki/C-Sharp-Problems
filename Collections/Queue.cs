// C# program to demonstrate Queue data structure. 
using System;
using System.Collections;
namespace QueueApplication {
    //Main Class
    public class MainClass {
        //Main method
        static void Main (string[] args) {
            //Instantiating Queue
            Queue q = new Queue ();
            //Enqueue
            q.Enqueue ('A');
            q.Enqueue ('M');
            q.Enqueue ('G');
            q.Enqueue ('W');
            Console.Write("Current queue:");
            //Traversing queue
            foreach (char c in q) {
                Console.Write (c + " ");
            }
            //Enqueue
            q.Enqueue ('V');
            q.Enqueue ('H');
            Console.Write("\nCurrent queue:");
            //Traversing queue
            foreach (char c in q) {
                Console.Write (c + " ");
            }
            Console.WriteLine ();
            Console.WriteLine ("Removing some values:");
            //Dequeue
            char ch = (char) q.Dequeue ();
            Console.WriteLine ("The removed value is:{0}", ch);
            //Dequeue
            ch = (char) q.Dequeue ();
            Console.WriteLine ("The removed value is:{0}", ch);
            Console.WriteLine ("Current queue:");
            //Traversing queue
            foreach (char c in q) {
                Console.Write (c + " ");
            }
            Console.ReadKey ();
        }
    }
}

//Pramesh Karki