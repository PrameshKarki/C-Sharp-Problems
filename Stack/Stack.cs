// Stack data structure implementation in C#
using System;
namespace StackProgram {
    class MainClass {
        static void Main (string[] args) {
            int option, value;
            bool status = true;
            UserInterface obj = new UserInterface ();
            Stack MyStack = new Stack ();
            while (status) {
                option = obj.DisplayBanner ();
                switch (option) {
                    case 1:
                        Console.Write ("Which element do you want to push? ");
                        value = Convert.ToInt32 (Console.ReadLine ());
                        MyStack.Push (value);
                        break;
                    case 2:
                        int poppedElement = MyStack.Pop ();
                        if (poppedElement != -1) {
                            Console.WriteLine ("The poped element is:{0}", poppedElement);
                        }
                        break;
                    case 3:
                        MyStack.Traverse ();
                        break;
                    case 4:
                        int topElement = MyStack.TopElement ();
                        if (topElement != -1) {
                            Console.WriteLine ("The top element is:{0}", topElement);
                        }
                        break;
                    case 5:
                        if (MyStack.IsEmpty ()) {
                            Console.WriteLine ("True!Stack is empty.");

                        } else {
                            Console.WriteLine ("False!Stack isn't empty.");
                        }
                        break;
                    case 6:
                        if (MyStack.IsFull ()) {
                            Console.WriteLine ("True!Stack is full.");

                        } else {
                            Console.WriteLine ("False!Stack isn't full.");
                        }
                        break;
                    case 7:
                        MyStack.MakeNull ();
                        break;
                    case 8:
                        status = false;
                        break;
                    default:
                        Console.WriteLine ("Error!!!Invalid choices");
                        break;
                }
                Console.WriteLine ("\n\tPress any key!");
                Console.ReadLine ();
            }
        }
    }
    class Stack {
        int top = -1, SIZE =5;
        int[] stackArray = new int[5];
        public void Push (int value) {
            if (!IsFull ()) {
                top++;
                stackArray[top] = value;
            } else {
                Console.WriteLine ("Error!Stack is full.");
                return;
            }
            Console.WriteLine("Sucessfully pushed.");

        }
        public int Pop () {
            if (!IsEmpty ()) {
                int poppedElement = stackArray[top];
                top--;
                return poppedElement;
            } else {
                Console.WriteLine ("Error!Stack is empty.");
                return -1;
            }
        }
        public void Traverse () {
            if (IsEmpty ()) {
                Console.WriteLine ("Stack is empty.");
            } else {
                Console.WriteLine ("The stack elements are:");
                for (int i = top; i >= 0; i--)
                    Console.WriteLine (stackArray[i]);
            }

        }
        public bool IsEmpty () {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool IsFull () {
            if (top >= SIZE-1)
                return true;
            else
                return false;
        }
        public int TopElement () {
            if (!IsEmpty ())
                return stackArray[top];
            else
                Console.WriteLine ("Error!Stack is empty.");
            return -1;
        }
        public void MakeNull () {
            top = -1;
            Console.WriteLine ("Operation sucessfull!!!");
        }
    }
    class UserInterface {
        public int DisplayBanner () {
            int choices;
            Console.WriteLine ("\tStack Opertations");
            Console.WriteLine ("--x--x--x--x--x--x--x--x--x--x--x--x");
            Console.WriteLine ("[1] Push element\n[2] Pop element\n[3] Traverse elements\n[4] Top element\n[5] Is empty?\n[6] Is full?\n[7] Delete all elements\n[8] Exit");
            Console.Write ("\n\n\nWhich operation do you want to perform? ");
            choices = Convert.ToInt32 (Console.ReadLine ());
            return choices;
        }

    }
}

//Pramesh Karki