using System;
namespace jagged{
    class Program{
        public static void Main(string [] args){
            int [][] A=new int [3][];
            A[0]=new int[5] {1,2,3,4,5};
            A[1]=new int[2]{6,7};
            A[2]=new int[3]{8,9,10};
             Console.WriteLine(A.Length);
            for(int i=0;i<A.Length;i++){
             for(int j=0;j<A[i].Length;j++){
                Console.Write(A[i][j]+" ");
            }
            Console.WriteLine();
        }
        }
    }
}
