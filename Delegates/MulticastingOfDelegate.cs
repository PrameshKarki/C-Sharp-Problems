// C# program to demonstrate Multicasting of delegates.
using System;
namespace DelegatesApplication {
public delegate void NumberChanger (int n);
    class TestDelegate {
         int num = 10;
        public  void AddNum (int p) {
            num += p;
        }
        public  void MultNum (int p) {
            num *= p;
        }
        public  int GetNum () {
            return num;
        }
        static void Main (string[] args) {
            TestDelegate obj=new TestDelegate();
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger (obj.AddNum);
            NumberChanger nc2 =new  NumberChanger (obj.MultNum);
            nc = nc1;
            nc += nc2;
            nc (5);
            Console.WriteLine ("Value of num:{0}", obj.GetNum ());

            Console.ReadKey ();
        }
    }
}

//Pramesh Karki