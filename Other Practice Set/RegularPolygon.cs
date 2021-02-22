/*TO DO:
1.This program should have following features:
-An interface called IRegularPolygon with two abstract methods:getNumSides and getSideLength
-A class Equilaterial Triangle that implements the interface,has getNumSides return 3 and getSideLength return
 an instance variable that is set by the constructor.
-A class square that implements the interface,has getNumSides return 4 and getSideLength return an instance variable that is 
 set by the constructor.
2.Add a static totalSides method,that given IRegularPolygon[],returns the sum of the number of sides of all the elements.
3.Add two default methods:
   -getPerimeter(n*length) where n is the number of sides
   -getInteriorAngle((n-2)PI/n in radians)
4.Make a few test cases.
*/
using System;
namespace PolygonProgram {
    //Main class
    public class MainClass {
        //This method will return the result in string format
        static int[] totalSides (IRegularPolygon[] polygonArray) {
            int length = polygonArray.Length;
            int[] myArray = new int[length];
            for (int i = 0; i < length; i++) {
                myArray[i] = polygonArray[i].getNumSides () * polygonArray[i].getSideLength ();
            }

            return myArray;
        }
        //Main method
        static void Main (string[] args) {
            //Declaring object
            EquilaterialTriangle obj = new EquilaterialTriangle ();
            Square obj1 = new Square ();

            Console.WriteLine ("Equilaterial Triangle:");
            Console.WriteLine ("Number OF Sides:{0}", obj.getNumSides ());
            Console.WriteLine ("Side Length:{0}", obj.getSideLength ());
            Console.WriteLine ("Perimeter:{0}", obj.getPerimeter ());
            Console.WriteLine ("Interior Angle:{0}", obj.getInteriorAngle ());

            Console.WriteLine ("\nSquare:");
            Console.WriteLine ("Number OF Sides:{0}", obj1.getNumSides ());
            Console.WriteLine ("Side Length:{0}", obj1.getSideLength ());
            Console.WriteLine ("Perimeter:{0}", obj1.getPerimeter ());
            Console.WriteLine ("Interior Angle:{0}", obj1.getInteriorAngle ());

            //Array of an interface objects
            IRegularPolygon[] polyArray = { new EquilaterialTriangle (), new Square () };
            int[] result = totalSides (polyArray);
            //Print result of totalSides() 
            for (int i = 0; i < result.Length; i++) {
                Console.WriteLine ("{0}.TotalSides():{1}", polyArray[i], result[i]);
            }

            Console.Read ();
        }
    }
    //Interface
    interface IRegularPolygon {
        int getNumSides ();
        int getSideLength ();
    }
    //Implementing EquilaterialTriangle class
    class EquilaterialTriangle : IRegularPolygon {
        private int length, numberOfSide = 3;
        const int PI = 180;
        public EquilaterialTriangle () {
            length = 10;
        }
        public int getNumSides () {
            return numberOfSide;
        }
        public int getSideLength () {
            return length;
        }
        public int getPerimeter () {
            return (numberOfSide * length);
        }
        public double getInteriorAngle () {
            return ((numberOfSide - 2) * PI / numberOfSide);
        }

    }
    //Implementing square class
    class Square : IRegularPolygon {
        private int length, numberOfSide = 4;
        const int PI = 180;
        public Square () {
            length = 4;
        }
        public int getNumSides () {
            return numberOfSide;
        }
        public int getSideLength () {
            return length;
        }
        public int getPerimeter () {
            return (numberOfSide * length);
        }
        public double getInteriorAngle () {
            return ((numberOfSide - 2) * PI / numberOfSide);
        }
    }
}

//Pramesh Karki