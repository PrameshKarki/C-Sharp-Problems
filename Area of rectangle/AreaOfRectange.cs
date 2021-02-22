// C# program to calculate the area of the rectangle
using System;
namespace CalculateArea{
    class AreaOfRectangle{
        static void Main(string[] args){
        Rectangle obj=new Rectangle();
        obj.GetValue();
        obj.CalculateArea();
        Console.Read();
        }

    }
    class Rectangle{
        int length,breadth;
        public void GetValue(){
            Console.WriteLine("----------Area of rectangle---------");
            Console.Write("Enter Length:");
            length=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Breadth:");
            breadth=Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateArea(){
            int area;
            area=length*breadth;
            Console.WriteLine("The area of the rectangle is:{0}",area);
        }
    }
}
//Pramesh Karki