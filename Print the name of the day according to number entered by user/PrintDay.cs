// C# program to print the name of the day according the number entered by user
using System;
namespace SwitchProgram{
    class MainClass{
        static void Main(string[] args){
            Day obj=new Day();
            obj.GetDay();
            obj.DisplayDay();
            Console.Read();

        }
    }
    class Day{
        int day;
        public void GetDay(){
            Console.Write("Enter the number of the day(1-7):");
            day=Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDay(){
            switch(day){
                case 1:Console.WriteLine("It is Sunday");
                break;
                case 2:Console.WriteLine("It is Monday");
                break;
                case 3:Console.WriteLine("It is Tuesday");
                break;
                case 4:Console.WriteLine("It is Wednesday");
                break;
                case 5:Console.WriteLine("It is Thursday");
                break;
                case 6:Console.WriteLine("It is Friday");
                break;
                case 7:Console.WriteLine("It is Saturday");
                break;
                default:Console.WriteLine("Sorry it is out of range!");
                break;
            }
        }
    }
}
//Pramesh Karki