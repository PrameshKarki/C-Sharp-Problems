// C# program to find sum of n natural number 
using System;
namespace SumProgram {
    class MainClass{
        static void Main (string[] args) {
            SumOfNaturalNumber obj=new SumOfNaturalNumber();
            obj.GetNumber();
            Console.WriteLine("Sum of first {0} natural number is:{1}",obj.number,obj.Sum());
            Console.Read();

        }
    }
    class SumOfNaturalNumber{
        public int number;
        public void GetNumber(){
            Console.Write("Enter n:");
            number=Convert.ToInt32(Console.ReadLine());

        }
        public int Sum(){
            int sum=0;
            for(int i=1;i<=number;i++){
                sum+=i;
            }
           return sum;
        }
    }
}
//Pramesh Karki