// C# program to demonstrate Stack data structure.
using System;
using System.Collections;
namespace StackApplication {
    //Main class
    public class MainClass {
        //Main method
        static void Main (string[] args) {
            //Instantiating stack
            Stack st = new Stack ();
            //Push
            st.Push ('M');
            st.Push ('A');
            st.Push ('G');
            st.Push ('W');
            Console.Write ("Current stack:");
            //Traverse
            foreach (char c in st) {
                Console.Write (c + " ");
            }
            //Push
            st.Push ('V');
            st.Push ('H');
            //Peek
            Console.WriteLine ("\nThe next poppable value in Stack:{0}", st.Peek ());
            Console.Write ("\nCurrent stack:");
            //Traverse
            foreach (char c in st) {
                Console.Write (c + " ");
            }
            Console.WriteLine ();
            Console.WriteLine ("Removing some values:");
            //Pop
            st.Pop ();
            st.Pop ();
            st.Pop ();
            Console.WriteLine ("Current stack:");
            //Traverse
            foreach (char c in st) {
                Console.Write (c + " ");
            }
            Console.ReadKey ();
        }
    }
}

//Pramesh Karki