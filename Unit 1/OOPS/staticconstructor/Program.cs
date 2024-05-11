using System;
namespace cons{
    class Program{
        static Program(){
            Console.WriteLine("Static Constructor:");
        }
        public Program(int i){
            Console.WriteLine("i="+i);
        }
        public Program(string name,int i){
            Console.WriteLine("name="+name);
            Console.WriteLine("i="+i);
        }
        public static void Main(string [] args){
          Program p1=new Program(4);
          Program p2=new Program("laxman",5);
          Program p3=new Program("ganesh",6);
        }
    }
}
