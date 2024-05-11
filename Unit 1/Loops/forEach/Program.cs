using System;
namespace forEach{
    class Program{
        public static void Main(string [] args){
            string [] names={"laxman","rohit","mahesh","sharad","bibek"};
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }
    }
}
