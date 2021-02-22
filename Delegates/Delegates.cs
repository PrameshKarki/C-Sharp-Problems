// C# program to demonstrate Delegate.
using System;
//Delegate declaration
delegate int NumberChanger(int n);
namespace DelegatesProgram{
    public class DelegatesDemo {
     int num=10;
        public int AddNum(int p){
            num+=p;
            return num;
        }
        public int MultNum(int q){
            num*=q;
            return num;
        }
        public int GetNum(){
            return num;
        }
        //Main Method
        static void Main (string[] args) {
            DelegatesDemo obj=new DelegatesDemo();
            //Delegate objects
            NumberChanger nc1=new NumberChanger(obj.AddNum);
            NumberChanger nc2=new NumberChanger(obj.MultNum);
            nc1(25);
            Console.WriteLine("Value of Num:{0}",obj.GetNum());
            nc2(5);
            Console.WriteLine("Value of Num:{0}",obj.GetNum());
            Console.Read ();
        }
    }
}

//Pramesh Karki