// C# program to find largest element in a single dimensional array
using System;
namespace largestElementProgram {
    class MainClass {
        static void Main (string[] args) {
            MyArray obj=new MyArray();
            obj.getSize();
            obj.getElements();
            Console.WriteLine("The largest element in an array:{0}",obj.getLargestElement());
            Console.Read();

        }
    }
    class MyArray{
        int size;
        int[] createdArray=new int[100];
         public void getSize(){
             Console.Write("Enter how many element do you want insert in an array:");
             size=Convert.ToInt32(Console.ReadLine());
             } 
         public void getElements(){
             Console.WriteLine("Enter {0} elements:",size);
             for(int index=0;index<size;index++){
                 createdArray[index]=Convert.ToInt32(Console.ReadLine());
             }
         }
         public int getLargestElement(){
              int largestElement;
              largestElement=createdArray[0];
             for(int index=1;index<size;index++){
                 if(largestElement<createdArray[index])
                 largestElement=createdArray[index];
             }
                 return largestElement;
         }
    }
}

//Pramesh Karki