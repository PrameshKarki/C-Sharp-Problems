// C# Console Calculator
using System;
namespace CalculatorProgram {
    class MainClass {
        static void Main (string[] args) {
            Calculator obj = new Calculator ();
            obj.displayBanner ();

        }
    }
    class Calculator {
        int firstNumber, secondNumber;
        bool calculatorStatus = true;
        public void displayBanner () {
            while (calculatorStatus) {
                int choices;
                Console.WriteLine ("\tConsole Calculator");
                Console.WriteLine ("--x--x--x--x--x--x--x--x--x--x--x--x");
                Console.WriteLine ("[1] Addition\n[2] Subtraction\n[3] Multiplication\n[4] Divison\n[5] Exit");
                Console.Write ("\n\nWhich operation do you want to perform?");
                choices = Convert.ToInt32 (Console.ReadLine ());
                switchChoices (choices);
                Console.WriteLine("\tPress any key!");
                Console.ReadLine ();
            }
        }
        private void switchChoices (int choices) {
            switch (choices) {
                case 1:
                    ReadNumbers ();
                    Sum ();
                    break;
                case 2:
                    ReadNumbers ();
                    Subtraction ();
                    break;
                case 3:
                    ReadNumbers ();
                    Multiplication ();
                    break;
                case 4:
                    ReadNumbers ();
                    Divison ();
                    break;
                case 5:
                    calculatorStatus = false;
                    break;
                default:
                    Console.WriteLine ("Invalid Choices!!!");
                    break;
            }

        }
        private void ReadNumbers () {
            Console.Write ("Enter first number:");
            firstNumber = Convert.ToInt32 (Console.ReadLine ());
            Console.Write ("Enter Second Number:");
            secondNumber = Convert.ToInt32 (Console.ReadLine ());
        }
        private void Sum () {
            int sum = firstNumber + secondNumber;
            Console.WriteLine ("The sum is:{0}", sum);
        }
        private void Subtraction () {
            int subtraction = firstNumber - secondNumber;
            Console.WriteLine ("The difference is:{0}", subtraction);

        }
        private void Multiplication () {
            int multiplication = firstNumber * secondNumber;
            Console.WriteLine ("The multiplication is:{0}", multiplication);
        }
        private void Divison () {
            int divison = firstNumber / secondNumber;
            Console.WriteLine ("The divison is:{0}", divison);
        }
    }
}

//Pramesh Karki