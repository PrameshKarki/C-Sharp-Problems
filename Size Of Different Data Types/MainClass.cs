//Program to show size of different C# data types
using System;
// Namespace Declaration
namespace Program{
    // Class Declaration
    class MainClass{
        // Main Method
        static void Main(string[] args){
            SizeOfDataType obj=new SizeOfDataType();
            obj.ShowSize();
            Console.Read();
        }
    }
    public class SizeOfDataType{
        public void ShowSize(){
            Console.WriteLine("The size of different data types of C# are:");
            Console.WriteLine("sizeof(int):{0}",sizeof(int));
            Console.WriteLine("sizeof(long):{0}",sizeof(long));
            Console.WriteLine("sizeof(float):{0}",sizeof(float));
            Console.WriteLine("sizeof(double):{0}",sizeof(double));
            Console.WriteLine("sizeof(char):{0}",sizeof(char));
            Console.WriteLine("sizeof(bool):{0}",sizeof(bool));
        }
    }
}
//Pramesh Karki




