//C# program to calculate factorial of user input number
using System;
namespace Program{
    class Factorial{
        static void Main(string[] args){
            CalculateFactorial obj=new CalculateFactorial();
            obj.GetNumber();
            obj.CalcFactorial();
            Console.Read();

        }
    }
    class CalculateFactorial{
        int number,result=1;
        public void GetNumber(){
            Console.Write("Enter any Number to calculate it's factorial:");
            number=Convert.ToInt32(Console.ReadLine());
        }
        public void CalcFactorial(){
            for(int i=number;i>0;i--){
                result*=i;
            }
            Console.WriteLine("Factorial is:{0}",result);
        }
    }
}
//Pramesh Karki