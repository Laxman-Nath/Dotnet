using System;
namespace indexers{
    class CreatingIndex{
        private int [] A=new int[4];
        public int this[int index]{
            get{
                return A[index];
            }
            set{
                A[index]=value;
            }
        }
    }
    class Program{
        public static void Main(string [] args){
            CreatingIndex ci=new CreatingIndex();
            ci[0]=12;
            ci[1]=13;
            ci[2]=14;
            for(int i=0;i<=2;i++){
                Console.WriteLine(ci[i]);
            }
        }
    }
}
