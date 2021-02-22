/*
TO DO:
Write an inheritance hierarchy for classes Quadrilateral, Trapezoid, Parallelogram,
Rectangle and Square. Use Quadrilateral as the superclass of the hierarchy. Create and use a
Point class to represent the points in each shape. Make the hierarchy as deep (i.e., as many
levels) as possible.
Specify the instance variables and methods for each class. The public instance variables of
Quadrilateral should be the x-y coordinate pairs for the four endpoints of the Quadrilateral.
Write a program that instantiates objects of your classes and outputs each object’s area (except
Quadrilateral).
*/
using System;
namespace QuadilateralProgram {
    // Quadrilateral class
    public class Quadrilateral {
        // The public instance variables of Quadrilateral that can contain x-y coordinate pairs
        // for the four endpoints of the Quadrilateral.
        public float[] firstPoint, secondPoint, thirdPoint, fourthPoint;

        // Calculate Area
        public virtual double Area () { return 0; }
        //Instantiate points
        public virtual void instantiatePoints () { }
        //Display Area
        public virtual void Display () { }

    }
    // Trapezoid class derived from Quadrilateral
    class Trapezoid : Quadrilateral {
        //Methods
        public override void instantiatePoints () {
            //Instantiating four points in clockwise direction
            Point fPoint = new Point (3, 4);
            Point sPoint = new Point (5, 4);
            Point tPoint = new Point (7, 2);
            Point foPoint = new Point (1, 2);
            //Get points as a array form
            firstPoint = fPoint.getPoint ();
            secondPoint = sPoint.getPoint ();
            thirdPoint = tPoint.getPoint ();
            fourthPoint = foPoint.getPoint ();

        }
        //Calculate Area
        public override double Area () {
            float a = thirdPoint[0] - fourthPoint[0];
            float b = secondPoint[0] - firstPoint[0];
            float h = firstPoint[1] - fourthPoint[1];
            float area = ((a + b) * h / 2);
            return area;
        }
        //Display Area
        public override void Display () {
            Console.WriteLine ("The area of Trapezoid with points A({0},{1}),B({2},{3}),C({4},{5}) and D({6},{7}) is {8} Sq.Meter", firstPoint[0], firstPoint[1], secondPoint[0], secondPoint[1], thirdPoint[0], thirdPoint[1], fourthPoint[0], fourthPoint[1], Area ());
        }

    }
    // Parallelogram class derived from Quadrilateral
    class Parallelogram : Quadrilateral {
        //Methods       
        public override void instantiatePoints () {
            //Instantiating four points in clockwise direction
            Point fPoint = new Point (5, 8);
            Point sPoint = new Point (10, 8);
            Point tPoint = new Point (7, 4);
            Point foPoint = new Point (2, 4);
            // Get points as a Array form
            firstPoint = fPoint.getPoint ();
            secondPoint = sPoint.getPoint ();
            thirdPoint = tPoint.getPoint ();
            fourthPoint = foPoint.getPoint ();

        }
        //Calcualte Area
        public override double Area () {
            float b = thirdPoint[0] - fourthPoint[0];
            float h = firstPoint[1] - fourthPoint[1];
            return (b * h);
        }
        //Display Area
        public override void Display () {
            Console.WriteLine ("The area of Parallelogram with points A({0},{1}),B({2},{3}),C({4},{5}) and D({6},{7}) is {8} Sq.Meter", firstPoint[0], firstPoint[1], secondPoint[0], secondPoint[1], thirdPoint[0], thirdPoint[1], fourthPoint[0], fourthPoint[1], Area ());
        }

    }
    // // Rectangle class derived from Quadrilateral
    class Rectangle : Quadrilateral {
        //Methods
        public override void instantiatePoints () {
            //Instantiating four points in clockwise direction
            Point fPoint = new Point (1, 6);
            Point sPoint = new Point (9, 6);
            Point tPoint = new Point (9, 2);
            Point foPoint = new Point (1, 2);
            // Get points as a Array form
            firstPoint = fPoint.getPoint ();
            secondPoint = sPoint.getPoint ();
            thirdPoint = tPoint.getPoint ();
            fourthPoint = foPoint.getPoint ();
        }
        //Calculate Area
        public override double Area () {
            float l = thirdPoint[0] - fourthPoint[0];
            float b = firstPoint[1] - fourthPoint[1];
            return (l * b);
        }
        //Display Area
        public override void Display () {
            Console.WriteLine ("The area of Rectangle with points A({0},{1}),B({2},{3}),C({4},{5}) and D({6},{7}) is {8} Sq.Meter", firstPoint[0], firstPoint[1], secondPoint[0], secondPoint[1], thirdPoint[0], thirdPoint[1], fourthPoint[0], fourthPoint[1], Area ());
        }

    }
    // Square class derived from Quadrilateral
    public class Square : Quadrilateral {
        //Method
        public override void instantiatePoints () {
            //Instantiating four points in clockwise direction
            Point fPoint = new Point (4, 8);
            Point sPoint = new Point (8, 8);
            Point tPoint = new Point (8, 4);
            Point foPoint = new Point (4, 4);
            // Get points as a Array form
            firstPoint = fPoint.getPoint ();
            secondPoint = sPoint.getPoint ();
            thirdPoint = tPoint.getPoint ();
            fourthPoint = foPoint.getPoint ();

        }
        //Calculate Area
        public override double Area () {
            float l = thirdPoint[0] - fourthPoint[0];
            return (Math.Pow (l, 2));
        }
        //Display Area
        public override void Display () {
            Console.WriteLine ("The area of Square with points A({0},{1}),B({2},{3}),C({4},{5}) and D({6},{7}) is {8} Sq.Meter", firstPoint[0], firstPoint[1], secondPoint[0], secondPoint[1], thirdPoint[0], thirdPoint[1], fourthPoint[0], fourthPoint[1], Area ());
        }
    }
    //Point class
    class Point {
        private float x, y;
        public Point () {
            x = 0;
            y = 0;
        }
        public Point (float givenX, float givenY) {
            x = givenX;
            y = givenY;
        }
        public float X {
            get { return x; }
            set { x = value; }
        }
        public float Y {
            get { return y; }
            set { y = value; }
        }
        public float[] getPoint () {
            float[] currentPoint = { x, y };
            return currentPoint;
        }
    }

    class MainClass {
        static void Main (string[] args) {
            //For Trapezoid
            Trapezoid newTrapezoid = new Trapezoid ();
            newTrapezoid.instantiatePoints ();
            newTrapezoid.Display ();

            //For Parallelogram
            Parallelogram newParallelogram = new Parallelogram ();
            newParallelogram.instantiatePoints ();
            newParallelogram.Display ();

            //For rectangle
            Rectangle newRectangle = new Rectangle ();
            newRectangle.instantiatePoints ();
            newRectangle.Display ();

            //For square
            Square newSquare = new Square ();
            newSquare.instantiatePoints ();
            newSquare.Display ();

            Console.ReadKey ();
        }
    }
}

//Pramesh Karki