// C# program to demonstrate Dictionary
using System;
using System.Collections.Generic;
namespace DictionaryProgram {
    //Main class
    public class MainClass {
        //Main method
        static void Main (string[] args) {
            //Instantiating Dictionary with string key value pair
            Dictionary<string, string> domains = new Dictionary<string, string> ();
            //Adding elements in the Dictionary
            domains.Add ("de", "Germany");
            domains.Add ("sk", "Slovakia");
            domains.Add ("us", "United States");
            domains.Add ("ru", "Russia");
            domains.Add ("hu", "Hungary");
            domains.Add ("pl", "Poland");
            //Acessing elements by Keys
            Console.WriteLine (domains["sk"]);
            Console.WriteLine (domains["de"]);
            //Count
            Console.WriteLine ("Dictionary has {0} items.", domains.Count);
            Console.WriteLine ("Keys of the dictionary:");
            //Instantiating list of string type
            List<string> keys = new List<string> (domains.Keys);
            //Traversing list
            foreach (string key in keys) {
                Console.WriteLine ("{0}", key);
            }
            Console.WriteLine ("Values of the dictionary:");
            //Instantiating list
            List<string> vals = new List<string> (domains.Values);
            //Traversing list
            foreach (string val in vals) {
                Console.WriteLine ("{0}", val);
            }
            Console.WriteLine ("Keys and Values of the dictionary:");
            //Trversing Dictionary with the help of key value pair
            foreach (KeyValuePair<string, string> kvp in domains) {
                Console.WriteLine ("Key={0},Value={1}", kvp.Key, kvp.Value);
            }

            Console.Read ();
        }
    }
}

//Pramesh Karki