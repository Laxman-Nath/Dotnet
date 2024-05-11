using System;
using System.Threading.Tasks;
namespace Application{
    class Program{
        public static void Main(string [] args){
        Method1();
        Method2();
        }
       public static async Task Method1(){
        await Task.Run(()=>{
            for(int i=1;i<=20;i++){
                Console.WriteLine("Method1");
            }
        });
       }
        public static void Method2(){
            for(int i=0;i<=20;i++){
                Console.WriteLine("Method2");
            }
        }
    }
}
