// C# program to demonstrate dictionary
using System;
using System.Collections.Generic;
namespace DictionaryProgram{
    public class MainClass {
        static void Main (string[] args) {
            Dictionary<int,string> person=new Dictionary<int,string>();
            person.Add(1,"Pramesh Karki");
            person.Add(2,"Abraham Villiers");
            person.Add(3,"Baburam Karki");

            Console.WriteLine("person[1]:{0}",person[1]);


            // lets create list of values
            List<string> personName=new List<string>(person.Values);
            Console.WriteLine("person.Values:");
            foreach(string element in personName){
                Console.WriteLine(element);
            }
            // person.Clear();
            //key value pair
            foreach(KeyValuePair<int,string> kvp in person){
                Console.WriteLine("person[{0}]:{1}",kvp.Key,kvp.Value);
            }
            Console.Read ();
        }
    }
}

//Pramesh Karki