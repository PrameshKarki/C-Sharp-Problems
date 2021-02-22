//C# Program to display multiplication table of user input number
using System;
namespace Program{
    class MultiplicationTable{
    static void Main(string[] args){
        Multiplication obj=new Multiplication();
        obj.GetNumber();
        obj.DisplayMultiplicationTable();
        Console.ReadLine();

    } 
  }
  class Multiplication{
      int number;
      public void GetNumber(){
          Console.Write("Enter any number to print its multiplication table:");
          number=Convert.ToInt32(Console.ReadLine());
      }
      public void DisplayMultiplicationTable(){
          Console.WriteLine("----Multiplication Table----------");
          Console.WriteLine("The multiplication table of "+number+" is:");
          for(int i=1;i<=10;i++)
            Console.WriteLine(number+"*"+i+"="+number*i);
      }
  }
}