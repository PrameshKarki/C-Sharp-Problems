/*
TO DO:
Create class SavingsAccount. Use a static variable annualInterestRate to store the
annual interest rate for all account holders. Each object of the class contains a private
instance variable savingsBalance indicating the amount the saver currently has on
deposit. Provide method calculateMonthlyInterest to calculate the monthly interest by
multiplying the savingsBalance by annualInterestRate divided by 12—this interest
should be added to savings Balance. Provide a static method modifyInterestRate that
sets the annualInterestRate to a new value. Write a program to test class
SavingsAccount. Instantiate two savingsAccount objects, saver1 and saver2, with
balances of $2000.00 and $3000.00, respectively. Set annualInterestRate to 4%, then
calculate the monthly interest for each of 12 months and print the new balances for both
savers. Next, set the annualInterestRate to 5%, calculate the next month’s interest and
print the new balances for both savers.
*/
using System;
namespace AccountApplication {
    //Mainclass
    class MainClass {
        //Main methods
        static void Main (string[] args) {
            //Instantiating SavingsAccount object
            SavingsAccount saver1 = new SavingsAccount (2000);
            SavingsAccount saver2 = new SavingsAccount (3000);
            //Display status of initial balance
            Console.WriteLine ("Initially:");
            saver1.Display ("Saver1");
            saver2.Display ("Saver2");

            saver1.calculateMonthlyInterest (month: 12);
            saver2.calculateMonthlyInterest (month: 12);
            // Display status of balance after 12 months with annualInterestRate 4
            Console.WriteLine ("\n\nCurrent Interest rate:4");
            Console.WriteLine ("After 12 Months:");
            saver1.Display ("Saver1");
            saver2.Display ("Saver2");
            //Change annualInterestRate 4 to 5
            SavingsAccount.modifyInterestRate (5);
            Console.WriteLine ("\n\nNext-->Current interest rate:5");
            //Display interest of 1 month
            Console.WriteLine ("Monthly interest of Saver1:{0}", saver1.showMonthlyInterest ());
            Console.WriteLine ("Monthly interest of Saver2:{0}", saver2.showMonthlyInterest ());

            saver2.calculateMonthlyInterest ();
            saver1.calculateMonthlyInterest ();
            //Display status after 1 month
            Console.WriteLine ("\nAfter 1 months:");
            saver1.Display ("Saver1");
            saver2.Display ("Saver2");

            Console.ReadKey ();
        }
    }
    //SavingsAccount class
    class SavingsAccount {
        //Static variable
        static private float annualInterestRate;
        //fields
        private float savingsBalance;
        //Default constructor
        public SavingsAccount () {
            savingsBalance = 0;
            annualInterestRate=4;
        }
        // Parameterized constructor
        public SavingsAccount (float money) {
            savingsBalance = money;
        }
        //Method to calculate monthly interest and add it to the main balance
        public void calculateMonthlyInterest (float month = 1) {
            float interest = (savingsBalance * annualInterestRate * month) / (100 * 12);
            savingsBalance += interest;
        }
        //Static method to modify interest rate
        static public void modifyInterestRate (float newInterestValue) {
            annualInterestRate = newInterestValue;
        }
        //Display status
        public void Display (string name) {
            Console.WriteLine ("Balance of {0}:{1}", name, savingsBalance);
        }
        //Method to display current monthly interest
        public float showMonthlyInterest () {
            return (savingsBalance * annualInterestRate) / (100 * 12);
        }

    }
}

//Pramesh Karki