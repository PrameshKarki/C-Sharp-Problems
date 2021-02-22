using System;
using System.Collections;
namespace StackApplication {
    public class MainClass {
        static void Main (string[] args) {
            Stack st= new Stack ();
            st.Push ('M');
            st.Push ("Adheri");
            st.Push (19);
            st.Push ("Hello World!");
            Console.Write("Current stack:");
            foreach (object c in st) {
                Console.Write (c + " ");
            }
            st.Push ('V');
            st.Push ('H');
            Console.WriteLine("\nThe next poppable value in Stack:{0}",st.Peek());
            Console.Write("\nCurrent stack:");
            foreach (object c in st) {
                Console.Write (c + " ");
            }
            Console.WriteLine ();
            Console.WriteLine ("Removing some values:");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine ("Current stack:");
            foreach (object c in st) {
                Console.Write (c + " ");
            }
            Console.ReadKey ();
        }
    }
}

//Pramesh Karki