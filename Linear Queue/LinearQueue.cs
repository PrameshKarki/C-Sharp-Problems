// Linear queue implementation in C#
using System;
namespace LinearQueueApplication {
    class MainClass {
        static void Main (string[] args) {
            int choice, value;
            bool status = true;
            UserInterface obj = new UserInterface ();
            Queue MyQueue = new Queue ();
            while (status) {
                choice = obj.UserChoice ();
                switch (choice) {
                    case 1:
                        Console.Write ("Which element do you want to enqueue? ");
                        value = Convert.ToInt32 (Console.ReadLine ());
                        MyQueue.enqueue (value);
                        break;
                    case 2:
                        int dequeuedElement = MyQueue.dequeue ();
                        if (dequeuedElement != -1) {
                            Console.WriteLine ("Dequeued element is:{0}", dequeuedElement);
                        }
                        break;
                    case 3:
                        MyQueue.Traverse ();
                        break;
                    case 4:
                        if (MyQueue.IsEmpty ()) {
                            Console.WriteLine ("True!Queue is empty.");
                        } else {
                            Console.WriteLine ("False!Queue isn't empty");
                        }
                        break;
                    case 5:
                        if (MyQueue.IsFull ()) {
                            Console.WriteLine ("True!Queue is full.");

                        } else {
                            Console.WriteLine ("False!Queue isn't full.");
                        }
                        break;
                    case 6:
                        MyQueue.MakeNull ();
                        Console.WriteLine ("Operation is sucessfull.");
                        break;
                    case 7:
                        status = false;
                        break;
                    default:
                        Console.WriteLine ("Error!!!Invalid choices.");
                        break;

                }
                Console.WriteLine ("\n\n\tPress any key!");
                Console.ReadLine ();
            }
        }
    }
    class Queue {
        int front, rear, SIZE = 5;
        int[] queueArray = new int[5];
        public Queue () {
            front = -1;
            rear = -1;
        }

        public void enqueue (int value) {
            if (IsFull ()) {
                Console.WriteLine ("Error!Queue is in overflow condition.");
                return;
            } else if (IsEmpty ()) {
                front = 0;
                rear = 0;
                queueArray[rear] = value;
            } else {
                rear++;
                queueArray[rear] = value;

            }
            Console.WriteLine ("Sucessfully enqueued.");
        }
        public int dequeue () {
            int dequeuedElement;
            if (IsEmpty ()) {
                Console.WriteLine ("Error! Queue is in underflow condition.");
                return -1;
            } else if (front == rear) {
                dequeuedElement = queueArray[front];
                front = -1;
                rear = -1;
                return dequeuedElement;
            } else {
                dequeuedElement = queueArray[front];
                front++;
                return dequeuedElement;

            }

        }
        public void MakeNull () {
            front = -1;
            rear = -1;
        }
        public bool IsEmpty () {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }
        public bool IsFull () {
            if (rear >= SIZE - 1)
                return true;
            else
                return false;
        }
        public void Traverse () {
            if (IsEmpty ()) {
                Console.WriteLine ("Error!Queue is empty.");
            } else {
                Console.WriteLine ("Queue elements are:");
                for (int index = front; index <= rear; index++)
                    Console.Write (queueArray[index] + " ");
            }
        }
    }
    class UserInterface {
        int choice;
        public int UserChoice () {
            Console.WriteLine ("\tQueue operations");
            Console.WriteLine ("--x--x--x--x--x--x--x--x--x--x--x");
            Console.WriteLine ("[1] Enqueue element\n[2] Dequeue element\n[3] Traverse elements\n[4] Is empty?\n[5] Is full?\n[6] Delete all elements\n[7] Exit");
            Console.Write ("\n\n\nWhich operation do you want to perform? ");
            choice = Convert.ToInt32 (Console.ReadLine ());
            return choice;
        }
    }
}

//Pramesh Karki