// Write a program in C# to demonstrate ArrayList Collection.
using System;
using System.Collections;
namespace CollectionProgram {
    //Empty class
    class Empty{

    }
    //Main class
    public class MainClass {
        //Main Method
        static void Main (string[] args) {
            //Instantiating ArrayList
            ArrayList da=new ArrayList();
            //Adding different elements in ArrayList
            da.Add("Hello World!");
            da.Add(11);
            da.Add(112);
            da.Add(212);
            da.Add(1212);
            da.Add(14412);
            da.Add(new Empty());
            da.Add(17);
            //Capacity
            Console.WriteLine("Capacity:{0}",da.Capacity);
            //Count
            Console.WriteLine("Count:{0}",da.Count);
            Console.WriteLine("Before Remove():");
            //Traversing ArrayList
            foreach(object el in da){
                Console.WriteLine(el);
            }
            //Removing a element
            da.Remove(112);
            Console.WriteLine("After Remove():");
            //Traversing ArrayList
            foreach(object el in da){
                Console.WriteLine(el);
            }
            
            Console.Read ();
        }
    }

}

//Pramesh Karki