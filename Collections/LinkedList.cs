//C# program to demonstrate Linkedlist(Collection/Data structure).
using System;
using System.Collections.Generic;
namespace LinkedListProgram {
    //Main class
    public class MainClass {
        //Main method
        static void Main (string[] args) {
            //Instantiating linkedlist
            LinkedList<int> nums=new LinkedList<int>();
            //Adding element at the end           
            nums.AddLast(23);
            nums.AddLast(34);
            nums.AddLast(33);
            nums.AddLast(11);
            nums.AddLast(6);
            //Adding element at the front
            nums.AddFirst(9);
            nums.AddFirst(7);
            //Finding Node
            LinkedListNode<int> node=nums.Find(6);
            //Inserting a node before the node found in above statement
            nums.AddBefore(node,5);
            //Traversing LinkedList
            Console.WriteLine("LinkedList elements are:");
            foreach(int num in nums){
                Console.WriteLine(num);
            }
            Console.Read ();
        }
    }
}

//Pramesh Karki