/*Task:
Define a simple class that represents information about a dog
   -The dog should have name and breed
   -If there is no name or breed assigned to the dog
        -It should named "Fido"
        -Its breed should be "Mongrel"
    -It Should be able to to view and change the name and breed of the dog
    -The Dog should be bark.
In Main Method:
   -Create three object of dog using different constructors
   -Put these into the array
   -Rename the dog using concept of parameters
   -Display information about individual dog
   -Iterate through array and bark each dog 
*/
using System;
namespace DogProgram {
    class MainClass {
        static void Main (string[] args) {
            Dog firstDog = new Dog ();
            Dog secondDog = new Dog ("Fritz", "German Shepherd");
            Dog thirdDog = new Dog ("Tommy", "Bull Dog");

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            firstDog.Display ("First");
            secondDog.Display ("Second");
            thirdDog.Display ("Third");

            firstDog.Name = "Bhotey";
            secondDog.Name = "Kaley";
            thirdDog.Name = "Ratey";
            firstDog.Name = "Bhotey";

            Console.WriteLine ("\nAfter renaming...");

            firstDog.Display ("First");
            secondDog.Display ("Second");
            thirdDog.Display ("Third");
            //Iterating through array of objects
            foreach (Dog dog in dogs) {
                dog.Bark ();
            }
            Console.Read ();
        }
    }
    class Dog {
        private string name, breed;
        public Dog () {
            name = "Fido";
            breed = "Mongrel";
        }
        public Dog (string dogName, string dogBreed) {
            name = dogName;
            breed = dogBreed;
        }
        public String Name {
            get { return name; }
            set { name = value; }
        }
        public string Breed {
            get { return breed; }
            set { breed = value; }
        }
        public void Display (string item) {
            Console.WriteLine ("\n{0} Dog:", item);
            Console.WriteLine ("Name:{0}\nBreed:{1}", name, breed);
        }
        public void Bark () {
            Console.WriteLine ("\n{0} said:wofff", name);
        }
    }
}

//Pramesh Karki