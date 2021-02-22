// C# program to demonstrate delegates
using System;
namespace DelegatesProgram {
    delegate double DoubleOp (double x);
    public class Program {
        static void Main (string[] args) {
            DoubleOp[] operations = {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };
            for (int i = 0; i < operations.Length; i++) {
                Console.WriteLine ("Using operations[{0}]", i);
                ProcessAndDisplayNumber (operations[i], 2.0);
                ProcessAndDisplayNumber (operations[i], 7.94);
                ProcessAndDisplayNumber (operations[i], 1.414);
                Console.WriteLine ("\n");
            }
            Console.ReadKey ();
        }
        static void ProcessAndDisplayNumber (DoubleOp action, double value) {
            double result = action (value);
            Console.WriteLine ("Value is {0},result of operation is {1}", value, result);
        }
    }
    class MathOperations {
        public static double MultiplyByTwo (double num) {
            return (num *= 2);
        }
        public static double Square (double num) {
            return (Math.Pow (num, 2));
        }
    }
}

//Pramesh Karki