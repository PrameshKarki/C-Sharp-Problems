//C# Program to print fibonacci series
using System;
namespace Program{
    class FibonacciSeries{
        static void Main(string[] args){
            FibonacciSeriesClass obj=new FibonacciSeriesClass();
            obj.GetTerms();
            obj.DisplayFibonacci();
            Console.ReadLine();

        }
    }
    class FibonacciSeriesClass{
        int a=0,b=1,c,terms;
        
        public void GetTerms(){
           Console.Write("Enter number of terms to print fibonacci series:");
           terms=Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayFibonacci(){
            Console.Write(a+" "+b);
               for(int i=0;i<(terms-2);i++){
                c=a+b;
                Console.Write(" "+c);
                a=b;
                b=c;
            }
        }
    }
}

//Pramesh Karki