// C# program to demonstrate Hashtable
using System;
using System.Collections;
namespace HashtableProgram {
    public class MainClass {
        static void Main (string[] args) {
            //Instantiating Hashtable
            Hashtable ht=new Hashtable();
            Console.WriteLine("Adding elements in the Hashtable");
            //Add
            ht.Add("001","Visual Basic");
            ht.Add("002","Java");
            ht.Add("003","C#");
            ht.Add("004","Python");
            ht.Add("005","C++");
            ht.Add("006","C");
            ht.Add("007","Lisp");
            if(ht.ContainsValue("F#")){
                Console.WriteLine("This entry is already in the list");

            }else{
                ht.Add("008","F#");
            }
            //Get a collection of the keys
            ICollection key=ht.Keys;
            foreach(string k in key){
                Console.WriteLine(k+": "+ht[k]);
            }
            Console.Read ();
        }
    }
}

//Pramesh Karki