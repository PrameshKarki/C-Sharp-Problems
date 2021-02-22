// C# program to demonstrate Namespace program.
using System;
namespace SampleNamespace{
    class SampleClass{
        public void SampleMethod(){
            Console.WriteLine("SampleMethod inside SampleNamespace");

        }
    }
    namespace NestedNamespace{
        class SampleClass{
            public void SampleMethod(){
                Console.WriteLine("SampleMethod inside NestedNamespace");
            }
        }
    }
    class Program{
        static void Main(string[] args){
            SampleClass outer=new SampleClass();
            outer.SampleMethod();
            SampleNamespace.SampleClass outer2=new SampleClass();
            outer2.SampleMethod();
            SampleNamespace.NestedNamespace.SampleClass inner=new NestedNamespace.SampleClass();
            inner.SampleMethod();
            Console.ReadKey();
        }
    }
}

//Pramesh Karki