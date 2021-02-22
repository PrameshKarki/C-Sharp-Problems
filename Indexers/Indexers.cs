// C# program to demonstrate Indexers.
using System;
namespace IndexerProgram {
    
    class IndexedNames {
        private string[] langlist = new string[size];
        static public int size = 10;
        public IndexedNames () {
            for (int i = 0; i < size; i++) {
                langlist[i] = "N A";
            }
        }
        public string this [int index] {
            get {
                string tmp;
                if (index >= 0 && index <= size - 1) {
                    tmp = langlist[index];
                } else {
                    tmp = "";
                }
                return tmp;
            }
            set{
                if(index>=0 && index <=size-1){
                    langlist[index]=value;
                }
            }
        }
        public void Greet(){
            Console.WriteLine("Hello World!!!");
        }
         static void Main (string[] args) {
            IndexedNames langs=new IndexedNames();
            langs[0]="Java";
            langs[1]="Visual Basic";
            langs[2]="C#";
            langs[3]="C";
            langs[4]="C++";
            langs[5]="Python";
            langs[6]="Javascript";
            for(int i=0;i<IndexedNames.size;i++){
                Console.WriteLine(langs[i]);
            }
            Console.Read ();
        }
    }

}

//Pramesh Karki