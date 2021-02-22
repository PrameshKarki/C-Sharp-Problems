// C# program to demonstrate method overloading
using System;
namespace MethodOverloadingProgram {
    class MainClass {
        static void Main (string[] args) {
          AddNumbers obj=new AddNumbers();
          Console.WriteLine("Sum(10,20):{0}",obj.Sum(10,20));
          Console.WriteLine("Sum(10,20,30):{0}",obj.Sum(10,20,30));
          Console.Read();
        }
    }
    class AddNumbers{
        public int Sum(int a,int b){
            return a+b;
        }
        public int Sum(int a,int b,int c){
            return a+b+c;
        }
    }
}

//Pramesh Karki