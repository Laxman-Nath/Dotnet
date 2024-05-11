using System;
using System.IO;
namespace fileio{
    class Program{
        public static void Main(string [] args){
          FileStream fis=new FileStream("dotnet.dat",FileMode.OpenOrCreate ,FileAccess.ReadWrite);
          for(int i=1;i<=20;i++){
            fis.WriteByte((byte) i);
          }
          fis.Position=0;
          for(int i=1;i<=20;i++){
            Console.Write(fis.ReadByte()+" ");
          }
          fis.Close();
          
        }
    }
}
