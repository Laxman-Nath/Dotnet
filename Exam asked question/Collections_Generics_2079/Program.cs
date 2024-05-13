// Write down the example for illustrating the collections and generics.
using System.Collections.Generic;
namespace myApplication {
    class Program { 
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(1);
            list.Add(2);
             list.Add(5);
            list.ForEach( p=>Console.WriteLine(p));
           
            list.Sort();
            list.ForEach(p => Console.WriteLine(p));

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Contains(1));
            Console.WriteLine(list.Remove(2));
            list.ForEach(p => Console.WriteLine(p));
        }
    }

}


