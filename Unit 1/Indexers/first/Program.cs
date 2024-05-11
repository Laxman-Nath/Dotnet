using System;
namespace indexers{
    class IndexerCreation{
        private string [] val=new string[3];
        public string this[int index]{
            get{
                return val[index];
            }
            set{
                val[index]=value;
            }
        }
    }
    class main{
        public static void Main(string [] args){
            IndexerCreation ic=new IndexerCreation();
            ic[0]="c";
            ic[1]="cpp";
            ic[2]="csharp";
            for(int i=0;i<=2;i++){
                Console.WriteLine(ic[i]);
            }
        }
    }
}

