/*
TO DO:
Create a class Rectangle with attributes length and width, each of which defaults to 1.
Provide methods that calculate the rectangle’s perimeter and area. It has set and get
methods for both length and width. The set methods should verify that length and width
are each floating-point numbers larger than 0.0 and less than 20.0.Write a program to test
class Rectangle.
*/
using System;
namespace RectangleProgram {
    //Main class
    class MainClass {
        static void Main (string[] args) {
            // Instantiating Rectangle object
            Rectangle obj = new Rectangle ();
            // Display rectangle details
            obj.Display ();
            Console.WriteLine ("Area:{0}", obj.Area ());
            Console.WriteLine ("Perimeter:{0}", obj.Perimeter ());
            //Again Instantiating Rectangle object
            Rectangle newRectangle=new Rectangle();
            //Setting length and width
            newRectangle.Length=18;
            newRectangle.Width=12;
            //Display rectangle details
            newRectangle.Display();
            Console.WriteLine("Area:{0}",newRectangle.Area());
            Console.WriteLine("Perimeter:{0}",newRectangle.Perimeter());

            Console.ReadKey ();
        }
    }
    //Rectangle class
    class Rectangle {
        //Fields
        private float length, width;
        //Default constructor
        public Rectangle () {
            length = 1;
            width = 1;
        }
        //Parameterized constructor
        public Rectangle (float l, float b) {
            length = l;
            width = b;
        }
        //Area
        public float Area () {
            return (length * width);
        }
        //Perimeter
        public float Perimeter () {
            return (2 * (length + width));
        }
        //Properties
        public float Length {
            get {
                return length;
            }
            set {
                if (value > 0 && value < 20) {
                    length = value;
                } else {
                    Console.WriteLine ("Error!!! Value should lies between 0 and 20.");
                }
            }
        }
        public float Width {
            get {
                return width;
            }
            set {
                if (value > 0 && value < 20) {
                    width = value;
                } else {
                    Console.WriteLine ("Error!!! Value should lies between 0 and 20");
                }
            }
        }
        //Method's to display detail of rectangle
        public void Display () {
            Console.WriteLine("\nRectangle details:");
            Console.WriteLine ("Length:{0}", length);
            Console.WriteLine ("Width:{0}", width);
        }
    }
}

//Pramesh Karki