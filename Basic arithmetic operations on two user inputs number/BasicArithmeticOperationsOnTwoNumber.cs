// C# program to perform basic arithmetic operations between two user input number
using System;
namespace Program{
    class BasicArithmeticOperationsOnTwoNumber{
        static void Main(string[] args){
         Calculation obj=new Calculation();
         obj.GetNumber();
         Console.WriteLine("Sum of "+obj.num1+" and "+obj.num2+" is:"+obj.Sum());
         Console.WriteLine("Subtraction of "+obj.num1+" and "+obj.num2+" is:"+obj.Subtraction());
         Console.WriteLine("Multiplication of "+obj.num1+" and "+obj.num2+" is:"+obj.Multiplication());
         Console.WriteLine("Divison of "+obj.num1+" and "+obj.num2+" is:"+obj.Divison());
         Console.ReadLine();
        }
    }
    
    class Calculation{
            public int num1,num2;
        public void GetNumber(){
               Console.Write("Enter First Number:");
               num1=Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter Second Number:");
               num2=Convert.ToInt32(Console.ReadLine());
        }
        public int Sum(){
            int sum;
            sum=num1+num2;
            return sum;
        }
        public int Multiplication(){
            int multiplication;
            multiplication=num1*num2;
            return multiplication;
        }
        public int Divison(){
            int divison;
            divison=num1/num2;
            return divison;
        }
        public int Subtraction(){
            int subtraction;
            subtraction=num1-num2;
            return subtraction;
        }
    }
}
//Pramesh Karki
