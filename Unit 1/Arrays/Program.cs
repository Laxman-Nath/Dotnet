// One dimensional array in c#
using System;
namespace Arrays{
class Program{
    public static void Main(string [] args){
        int [] A={1,2,3,4,5,6};
        int[] B=new int[5] {6,7,8,9,10};
        int [] C=new int[] {9,10,11,12};
        int [] D={12,13,14};
        for(int i=0;i<5;i++){
            Console.WriteLine("The element of Array A at index "+i +" is "+A[i]);
        }
    }
}
}
