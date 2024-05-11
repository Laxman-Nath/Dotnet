using System;
using System.Collections.Generic;
using System.Linq;
namespace lambda{
    class Program{
      
        public static void Main(string [] args){
          List<int> numbers=new List<int>{1,2,3,4,5,6,7,8};
          var evenNumbers=numbers.Where(x => x % 2 == 0);
          foreach(var num in evenNumbers){
            Console.WriteLine(num);
          }
        
    }
}
}
