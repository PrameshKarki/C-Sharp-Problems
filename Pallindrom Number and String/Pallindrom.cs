// C# program to check pallindrom string and number
using System;
namespace PallindromNumber {
    class MainClass {
        static void Main (string[] args) {
            Pallindrom obj = new Pallindrom ();
            obj.GetString ();
            obj.GetNumber ();
            Console.Read ();

        }
    }
    class Pallindrom {
        public void GetString () {
            string givenString;
            Console.Write ("Enter any string to check wheather it is pallindrom or not:");
            givenString = Console.ReadLine ();
            if (IsPallindromString (givenString)) {
                Console.WriteLine ("{0} is pallindrom string.", givenString);

            } else {

                Console.WriteLine ("{0} is not pallindrom string.", givenString);
            }
        }
        private bool IsPallindromNumer (int givenNumber) {
            int reverseNumber = 0, orginalNumber = givenNumber;
            while (givenNumber > 0) {
                int remainder = givenNumber % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                givenNumber = givenNumber / 10;
            }
            return (reverseNumber == orginalNumber);
        }
        public void GetNumber () {
            int givenNumber;
            Console.Write ("Enter any number to check wheather it is pallindrom or not:");
            givenNumber = Convert.ToInt32 (Console.ReadLine ());
            if (IsPallindromNumer (givenNumber)) {
                Console.WriteLine ("{0} is pallindrom number.", givenNumber);

            } else {
                Console.WriteLine ("{0} isnt pallindrom Number.", givenNumber);

            }
        }
        private bool IsPallindromString (string givenString) {
            string reversedString = "";
            int length = givenString.Length - 1;
            while (length >= 0) {
                reversedString += givenString[length];
                length--;
            }
            if (givenString == reversedString)
                return true;
            else
                return false;
        }

    }
}

//Pramesh Karki
