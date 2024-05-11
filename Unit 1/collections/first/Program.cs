using System;
using System.Collections;
namespace collectionApplication{
class Program{
    public static void Main(string [] args){
       ArrayList al=new ArrayList();
       al.Add(23);
       al.Add(34);
       al.Add(35);
       al.Add(3);
       al.Add(1);
       al.Add(90);
       al.Add(100);
       Console.WriteLine("Capacity:"+al.Capacity);
       Console.WriteLine("Count:"+al.Count);
       Console.WriteLine("Before sorting:");
       foreach(int i in al){
        Console.Write(i + ",");
       }
       Console.WriteLine();
       al.Sort();
         foreach(int i in al){
        Console.Write(i + ",");
       }
    }
}
}
