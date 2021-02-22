// C# program to demonstrate Hashtable
using System;
using System.Collections;

namespace HashtableProgram {
    public class MainClass {
        static void Main (string[] args) {
            //Instantiating Hashtable
            Hashtable ht=new Hashtable();
            Console.WriteLine("Adding elements in the Hashtable");
            ht.Add(1,"Visual Basic");
            ht.Add("Second","Javascript");
            ht.Add('C',3);
            ht.Add("Fourth","PHP");
            ArrayList al=new ArrayList(ht.Keys);
           
            //Get a collection of the keys
            Console.WriteLine("Keys:");
            foreach(object k in al){
                Console.WriteLine(k);
            }
            Console.WriteLine("Key Value:");
            foreach(object key in al){
                Console.WriteLine("ht[{0}]:{1}",key,ht[key]);
            }
            Console.WriteLine("ht[Fourth]:{0}",ht["Fourth"]);
            Console.WriteLine("I am acessing keys:");
            foreach(object key in ht.Keys){
                Console.WriteLine(key);
            }
            Console.Read ();
        }
    }
}

//Pramesh Karki