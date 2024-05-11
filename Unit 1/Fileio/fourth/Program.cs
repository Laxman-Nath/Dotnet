/* Writing in and reading from text file */
using System;
using System.IO;
namespace fileio{
    class Program{
        public static void Main(string [] args){
            string writeText="Hello world";
             File.WriteAllText("file.txt",writeText);
             string readText=File.ReadAllText("file.txt");
             Console.WriteLine(readText);
             Console.ReadKey();
        }
    }
}
