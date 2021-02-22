// C# program to print the name of month according to number entered by user
using System;
namespace DisplayMonthProgram {
    class MainClass {
        static void Main (string[] args) {
            Month obj = new Month ();
            obj.GetIndex ();
            obj.PrintMonth ();
            Console.Read ();

        }
    }
    class Month {
        int choice;
        public void GetIndex () {
            Console.Write("Enter any number to print corresponding name of the month:");
            choice =Convert.ToInt32(Console.ReadLine ());
        }
       public void PrintMonth () {
            switch (choice) {
                case 1:
                    Console.WriteLine ("It's january.");
                    break;
                case 2:
                    Console.WriteLine ("It's February.");
                    break;
                case 3:
                    Console.WriteLine ("It's March.");
                    break;
                case 4:
                    Console.WriteLine ("It's April.");
                    break;
                case 5:
                    Console.WriteLine ("It's May.");
                    break;
                case 6:
                    Console.WriteLine ("It's June.");
                    break;
                case 7:
                    Console.WriteLine ("It's July.");
                    break;
                case 8:
                    Console.WriteLine ("It's Auguest.");
                    break;
                case 9:
                    Console.WriteLine ("It's September.");
                    break;
                case 10:
                    Console.WriteLine ("It's October.");
                    break;
                case 11:
                    Console.WriteLine ("It's November.");
                    break;
                case 12:
                    Console.WriteLine ("It's December.");
                    break;
                default:
                    Console.WriteLine ("Invalid Options!!!");
                    break;

            }
        }
    }
}
//Pramesh Karki