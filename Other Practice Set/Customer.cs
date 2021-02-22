/*
Task:
Create a class Customer with id, name,balanceAmount.
Create a parameterized constructor to set customer details.
Create a method void showInfo() to show the customer details.
Create a method void deposit(double amount) to deposit the given amount. Update the
balanceAmount after deposit.
Create a method void withdraw(double amount) to withdraw the given amount. Check to see
if withdraw is possible or not. Update the balanceAmount if withdraw is done.
Provide a test class.
*/
using System;
namespace BankApplication {
    // Main Class
    public class MainClass {
        static void Main (string[] args) {
            UserInterface obj = new UserInterface ();
            obj.Banner ();
        }
    }
    // Customer class
    class Customer {
        private int id;
        private double balanceAmount;
        private string name;
        //Default constructor
        public Customer () {
            name = "undefined";
            id = 0;
            balanceAmount = 0;
        }
        //Parameterized constructor
        public Customer (int givenID, string givenName, double givenBalance) {
            id = givenID;
            name = givenName;
            balanceAmount = givenBalance;
        }
        //Show customer details
        public void ShowInfo () {
            Console.WriteLine ("----Info----");
            Console.WriteLine ("ID:{0}\nName:{1}\nBalance:{2}", id, name, balanceAmount);
        }
        //Deposit money
        public void Deposit (double balance) {
            balanceAmount += balance;
            Console.WriteLine ("\nBalance deposited sucessfully.");
        }
        //Withdraw money
        public void WithDraw (double balance) {
            if (balanceAmount >= balance) {
                balanceAmount -= balance;
                Console.WriteLine ("Balance withdrawn sucessfully.");
            } else {
                Console.WriteLine ("Sorry!You dont have enough balance.");
            }
        }

    }
    // User interface class
    class UserInterface {
        private int userOption;
        private bool status = true;
       Customer newCustomer = new Customer ();
       public void Banner () {
            while (status) {
                Console.WriteLine ("------PRAMESH BANK------");
                Console.WriteLine ("[1] Create new account\n[2] Show information\n[3] Deposite money\n[4] Withdraw money\n[5] Exit");
                Console.Write ("\n\nWhich operation do you want to perform? ");
                userOption = Convert.ToInt32 (Console.ReadLine ());
                SwichOption (userOption);
                Console.WriteLine("\n\n\nPress any key!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public void SwichOption (int choice) {
            int id;
            double balanceAmount,money;
            string name;
            switch (choice) {
                case 1:
                    Console.Write ("Enter User ID: ");
                    id = Convert.ToInt32 (Console.ReadLine ());
                    Console.Write ("Enter Name: ");
                    name = Console.ReadLine ();
                    Console.Write ("Enter Balance: ");
                    balanceAmount = Convert.ToDouble (Console.ReadLine ());
                    newCustomer = new Customer (id, name, balanceAmount);
                    Console.WriteLine ("Operation Sucessfull.");
                    break;
                case 2:
                    newCustomer.ShowInfo ();
                    break;
                case 3:
                    Console.Write ("How much money do you want to deposit? ");
                    money = Convert.ToDouble (Console.ReadLine ());
                    newCustomer.Deposit (money);
                    break;
                case 4:
                    Console.Write ("How much money do you want to withdraw? ");
                    money = Convert.ToDouble (Console.ReadLine ());
                    newCustomer.WithDraw (money);
                    break;
                case 5:
                    status = false;
                    break;
                default:
                    Console.WriteLine ("Error!!! Please enter valid option.");
                    break;

            }
        }
    }
}

//Pramesh Karki