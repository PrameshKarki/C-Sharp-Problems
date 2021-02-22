// C# program to print armstrong numbers between 1 and 1000
using System;
namespace ArmstrongNumberProgram {
    class MainClass {
        static void Main (string[] args) {
            Armstrong obj = new Armstrong ();
            obj.DisplayArmstrongNumber ();
            Console.Read ();

        }
    }
    class Armstrong {
        public void DisplayArmstrongNumber () {
            int min = 0, max = 1000;
            Console.WriteLine ("Armstrong numbers between 1 and 1000 are:");
            for (int i = min; i < max; i++) {
                if (IsArmStrong (i)) {
                    Console.Write (i + " ");
                }
            }
        }
        private bool IsArmStrong (int number) {
            int sum = 0, orginalNumber = number;
            while (number > 0) {
                int remainder = number % 10;
                sum += (int) Math.Pow (remainder, 3);
                number /= 10;
            }
            if (orginalNumber == sum)
                return true;
            else
                return false;

        }
    }
}

//Pramesh Karki