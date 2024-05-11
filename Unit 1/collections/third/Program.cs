using System;
namespace set{
    class Program{
        public static void Main(string [] args){
            HashSet<int> set=new HashSet<int>();
            set.Add(19);
            set.Add(34);
            set.Add(23);
            set.Add(34);
            set.Remove(19);
            foreach(int i in set){
            Console.Write(i+",");
            }
            Console.WriteLine(set.Contains(23));
        }
    }
}
