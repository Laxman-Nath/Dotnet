using System;
namespace GenericApplication{
    class Program{
        public static void Main(string [] args){
            List<int> li=new List<int>();
            li.Add(23);
             li.Add(24);
             li.Add(24);
            li.Add(45);
            li.Add(59);
            li.Add(2);
            li.Add(4);
            Console.WriteLine("Capacity:"+li.Capacity);
            Console.WriteLine("Count:"+li.Count);
            Console.WriteLine(" Before sorting:");
            foreach(int i in li){
                Console.Write(i+",");
            }
            Console.WriteLine();
            li.Sort();
            Console.WriteLine("After sorting:");
            foreach(int i in li){
                Console.Write(i+",");
            }

        }
    }
}
